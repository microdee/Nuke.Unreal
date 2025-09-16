#!/usr/bin/env bash

bash --version 2>&1 | head -n 1

set -eo pipefail
SCRIPT_DIR=$(cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd)

###########################################################################
# CONFIGURATION
###########################################################################

BUILD_PROJECT_NAME="_build"
BUILD_PROJECT_FOLDER="$SCRIPT_DIR/build"
BUILD_PROJECT_FILE="$BUILD_PROJECT_FOLDER/$BUILD_PROJECT_NAME.csproj"
BUILD_EXE="$BUILD_PROJECT_FOLDER/bin/Debug/$BUILD_PROJECT_NAME.exe"
TEMP_DIRECTORY="$SCRIPT_DIR//.nuke/temp"

DOTNET_GLOBAL_FILE="$SCRIPT_DIR//global.json"
DOTNET_INSTALL_URL="https://dot.net/v1/dotnet-install.sh"
DOTNET_CHANNEL="STS"

export DOTNET_CLI_TELEMETRY_OPTOUT=1
export DOTNET_NOLOGO=1

###########################################################################
# EXECUTION
###########################################################################

ATTEMPT_BINARY_REUSE=[ $REUSE_COMPILED || ( "$@" == *"ReuseCompiled"* ) ]

if [[ ( "$REUSE_COMPILED" == "1" || ( "$@" == *"ReuseCompiled"* ) ) && ( -f "$BUILD_EXE" ) ]]; then
    "$DOTNET_EXE" run --project "$BUILD_PROJECT_FILE" --no-build -- "$@"
else
    function FirstJsonValue {
        perl -nle 'print $1 if m{"'"$1"'": "([^"]+)",?}' <<< "${@:2}"
    }

    # If dotnet CLI is installed globally and it matches requested version, use for execution
    if [ -x "$(command -v dotnet)" ] && dotnet --version &>/dev/null; then
        export DOTNET_EXE="$(command -v dotnet)"
    else
        # Download install script
        DOTNET_INSTALL_FILE="$TEMP_DIRECTORY/dotnet-install.sh"
        mkdir -p "$TEMP_DIRECTORY"
        curl -Lsfo "$DOTNET_INSTALL_FILE" "$DOTNET_INSTALL_URL"
        chmod +x "$DOTNET_INSTALL_FILE"

        # If global.json exists, load expected version
        if [[ -f "$DOTNET_GLOBAL_FILE" ]]; then
            DOTNET_VERSION=$(FirstJsonValue "version" "$(cat "$DOTNET_GLOBAL_FILE")")
            if [[ "$DOTNET_VERSION" == ""  ]]; then
                unset DOTNET_VERSION
            fi
        fi

        # Install by channel or version
        DOTNET_DIRECTORY="$TEMP_DIRECTORY/dotnet-unix"
        if [[ -z ${DOTNET_VERSION+x} ]]; then
            "$DOTNET_INSTALL_FILE" --install-dir "$DOTNET_DIRECTORY" --channel "$DOTNET_CHANNEL" --no-path
        else
            "$DOTNET_INSTALL_FILE" --install-dir "$DOTNET_DIRECTORY" --version "$DOTNET_VERSION" --no-path
        fi
        export DOTNET_EXE="$DOTNET_DIRECTORY/dotnet"
        export PATH="$DOTNET_DIRECTORY:$PATH"
    fi

    echo "Microsoft (R) .NET SDK version $("$DOTNET_EXE" --version)"

    if [[ ! -z ${NUKE_ENTERPRISE_TOKEN+x} && "$NUKE_ENTERPRISE_TOKEN" != "" ]]; then
        "$DOTNET_EXE" nuget remove source "nuke-enterprise" &>/dev/null || true
        "$DOTNET_EXE" nuget add source "https://f.feedz.io/nuke/enterprise/nuget" --name "nuke-enterprise" --username "PAT" --password "$NUKE_ENTERPRISE_TOKEN" --store-password-in-clear-text &>/dev/null || true
    fi

    "$DOTNET_EXE" build "$BUILD_PROJECT_FILE" /nodeReuse:false /p:UseSharedCompilation=false -nologo -clp:NoSummary --verbosity quiet
    "$DOTNET_EXE" run --project "$BUILD_PROJECT_FILE" --no-build -- "$@"
fi

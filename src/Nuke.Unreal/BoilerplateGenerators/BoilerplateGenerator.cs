using System;
using System.Linq;
using System.Reflection;
using System.IO;
using Nuke.Common;
using Nuke.Common.IO;
using Scriban;
using Serilog;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class BoilerplateGenerator
    {
        public static AbsolutePath DefaultTemplateFolder => BuildCommon.GetContentsFolder() / "Templates";

        protected static void CheckErrors(Template template)
        {
            if(!template.HasErrors) return;
            throw new ScribanParseException(template);
        }

        /// <summary>
        /// Render a file from a scriban template.
        /// </summary>
        /// <param name="templateRoot"></param>
        /// <param name="source"></param>
        /// <param name="destinationFolder"></param>
        /// <param name="model"></param>
        protected static void RenderFile(AbsolutePath templateRoot, RelativePath source, AbsolutePath destinationFolder, object model)
        {
            var relFileTemplate = Template.Parse(source, templateRoot / source);
            CheckErrors(relFileTemplate);

            var textTemplate = Template.Parse(File.ReadAllText(templateRoot / source), templateRoot / source);
            CheckErrors(textTemplate);

            var renderedRelFilePath = relFileTemplate.Render(model);
            var renderedText = textTemplate.Render(model);

            var resultPath = destinationFolder / renderedRelFilePath;
            var resultFilename = Path.GetFileNameWithoutExtension(resultPath);
            var resultExt = Path.GetExtension(resultPath).Replace("sbn", "");

            if(!Directory.Exists(resultPath.Parent))
                Directory.CreateDirectory(resultPath.Parent);

            var outPath = (resultPath.Parent / resultFilename) + resultExt;

            Log.Debug($"Rendering to: {resultFilename + resultExt}");

            File.WriteAllText(outPath, renderedText);
        }

        /// <summary>
        /// Render scriban templated scaffoldings and files to destination folder.
        /// </summary>
        /// <param name="templateRoot"></param>
        /// <param name="destinationFolder"></param>
        /// <param name="model"></param>
        /// <param name="currentFolder">This is != the current Working Directory! It should be only used by subsequent recursive function calls</param>
        protected static void RenderFolder(AbsolutePath templateRoot, AbsolutePath destinationFolder, object model, AbsolutePath currentFolder = null)
        {
            currentFolder ??= templateRoot;
            foreach(var file in Directory.EnumerateFiles(currentFolder))
            {
                var relPath = (RelativePath) Path.GetRelativePath(templateRoot, file);
                RenderFile(templateRoot, relPath, destinationFolder, model);
            }

            foreach(var dir in Directory.EnumerateDirectories(currentFolder))
            {
                RenderFolder(templateRoot, destinationFolder, model, (AbsolutePath) dir);
            }
        }
    }

    public class CommonModelBase
    {
        public string Name { get; init; }
        public string Copyright { get; init; }
    }

    public class ScribanParseException : Exception
    {
        public ScribanParseException(Template template) : base(GetMessage(template))
        {
        }

        private static string GetMessage(Template template)
        {
            var nl = Environment.NewLine;
            var errors = string.Join(nl + "    ", template.Messages.Select(m => m.ToString()));
            return $"Parsing scriban template threw an error:{nl}"
                + $"  at {template.SourceFilePath}:{nl}    {errors}";
        }
    }
}
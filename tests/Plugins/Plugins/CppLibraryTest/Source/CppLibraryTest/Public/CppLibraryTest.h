// Fill in Copyright info...

#pragma once

#include "Modules/ModuleManager.h"

class FCppLibraryTestModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
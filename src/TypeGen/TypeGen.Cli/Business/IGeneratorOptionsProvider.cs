﻿using System.Collections.Generic;
using System.Reflection;
using TypeGen.Cli.Models;
using TypeGen.Core;

namespace TypeGen.Cli.Business
{
    internal interface IGeneratorOptionsProvider
    {
        /// <summary>
        /// Returns the GeneratorOptions object based on the passed ConfigParams
        /// </summary>
        /// <param name="config"></param>
        /// <param name="assemblies"></param>
        /// <param name="projectFolder"></param>
        /// <param name="logVerbose"></param>
        /// <returns></returns>
        GeneratorOptions GetGeneratorOptions(TgConfig config, IEnumerable<Assembly> assemblies, string projectFolder, bool logVerbose);
    }
}
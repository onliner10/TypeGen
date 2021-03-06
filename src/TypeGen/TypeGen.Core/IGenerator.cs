using System;
using System.Collections.Generic;
using System.Reflection;

namespace TypeGen.Core
{
    /// <summary>
    /// Interface for a TypeScript generator class
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// The generator options
        /// </summary>
        GeneratorOptions Options { get; set; }

        /// <summary>
        /// Generates TypeScript files for C# types in assemblies
        /// </summary>
        /// <param name="assemblies"></param>
        GenerationResult Generate(IEnumerable<Assembly> assemblies);

        /// <summary>
        /// Generates TypeScript files for C# types in an assembly
        /// </summary>
        /// <param name="assembly"></param>
        GenerationResult Generate(Assembly assembly);

        /// <summary>
        /// Generate TypeScript files for a given type
        /// </summary>
        /// <param name="type"></param>
        GenerationResult Generate(Type type);
    }
}
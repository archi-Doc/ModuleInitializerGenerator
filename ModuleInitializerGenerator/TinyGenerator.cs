using Microsoft.CodeAnalysis;
using System;

namespace ModuleInitializerGenerator
{
    [Generator]
    public class TinyGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context) { }

        public void Execute(GeneratorExecutionContext context)
        {
            var text = @"namespace ModuleInitializerGenerator
{
    public static class TinyClass
    {
        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        public static void Initialize()
        {
        }
    }
}";
            context.AddSource($"Generator_ModuleInitializer_gen.cs", text);
        }
    }
}

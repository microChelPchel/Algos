using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace AlgorithmAndStructedData.Logic
{
    internal static class CompilatorHelper
    {

        public static CompilerResults Compliler(string code)
        {
            //params
            Dictionary<string, string> parametrsProvider = new Dictionary<string, string>() { { "CompilerVersion", "v4.0" } };
            CSharpCodeProvider provider = new CSharpCodeProvider(parametrsProvider);
            var libers = new string[] { "mscorlib.dll", "System.Core.dll" };
            CompilerParameters parametrs = new CompilerParameters(libers, "resultCompil.exe", true);
            parametrs.GenerateExecutable = true;
            return provider.CompileAssemblyFromSource(parametrs, code);
        
        }

    }
}

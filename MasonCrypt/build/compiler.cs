using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

namespace MasonCrypt.build
{
    public class Compiler
    {
        public string Compile(Builder builder)
        {
            string destinationIconPath = Environment.CurrentDirectory + "\\icon.ico";

            try
            {
                Directory.CreateDirectory(builder.TempDirectory);
                string[] referencedAssemblies = new string[] { "System.dll", "System.IO.dll", "System.Management.dll", "System.Reflection.dll", "System.Runtime.InteropServices.dll", "System.Security.Principal.dll", "System.Threading.dll", "System.Windows.Forms.dll" };
                Dictionary<string, string> providerOptions = new Dictionary<string, string>() { { "CompilerVersion", "v4.0" } };

                string compilerOptions = "/target:winexe /platform:anycpu /optimize+";

                using (CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider(providerOptions))
                {
                    CompilerParameters compilerParameters = new CompilerParameters(referencedAssemblies)
                    {
                        GenerateExecutable = true,
                        OutputAssembly = builder.SaveFileName,
                        CompilerOptions = compilerOptions,
                        TreatWarningsAsErrors = false,
                        IncludeDebugInformation = false,
                        TempFiles = new TempFileCollection(builder.TempDirectory, false),
                    };

                    CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, builder.StubCs);
                    if (compilerResults.Errors.Count > 0)
                    {
                        string errorMessage = "Compilation Error:\n";
                        foreach (CompilerError compilerError in compilerResults.Errors)
                        {
                            errorMessage += string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}\n",
                                compilerError.ErrorText, compilerError.Line, compilerError.Column, compilerError.FileName);
                        }
                        return errorMessage;
                    }

                    try
                    {
                        if (File.Exists(destinationIconPath)) File.Delete(destinationIconPath);
                        if (Directory.Exists(builder.TempDirectory)) Directory.Delete(builder.TempDirectory, true);
                    }
                    catch { }

                    return "Done!";
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (File.Exists(destinationIconPath)) File.Delete(destinationIconPath);
                    if (Directory.Exists(builder.TempDirectory)) Directory.Delete(builder.TempDirectory, true);
                }
                catch { }

                return ex.Message;
            }
        }
    }
}

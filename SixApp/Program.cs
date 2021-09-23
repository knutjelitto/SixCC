using Six.Ceylon;
using Six.Ceylon.Errors;
using Six.Tools;
using System;

namespace SixApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //new Processor().Process();
                //new Processor().LoadModule(DirectoryRef.From(@"D:\SixSrc\ceylon\language"));
                new Processor().LoadAllModules(DirectoryRef.From(@"D:\SixSrc\ceylon"));
            }
            catch (ErrorException error)
            {
                Console.WriteLine();
                error.Error.Report(Console.Out);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.Write("any key ... ");
                Console.ReadKey(true);
            }
        }
    }
}

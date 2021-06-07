using System;
using System.Diagnostics;

namespace DI.Services
{
    public class OsCommandInjectionService : IOsCommandInjectionService
    {
        public void RunOsCommand(string command)
        {
            try 
            {
                var process = Process.Start(command);
            } 
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void RunOsCommandWithStartInfo(string command)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    FileName = command
                };

                var process = Process.Start(processStartInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void RunPythonWithArgs(string args)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    FileName = @"python.exe",
                    Arguments = args,
                    UseShellExecute = false
                };

                var process = Process.Start(processStartInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

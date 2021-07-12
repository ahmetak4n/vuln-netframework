using System;
using System.Diagnostics;

namespace DI.Services
{
    public class OsCommandInjectionService : IOsCommandInjectionService
    {
        public string Classic(string ip)
        {
            string result = "";

            try
            {
                Process process = new Process();

                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c ping " + ip;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                result = process.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Blind(string command)
        {
            string result = "Host not found";
            try
            {
                Process process = new Process();

                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c ping " + command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                var console = process.StandardOutput.ReadToEnd();

                if (!console.Contains("Ping request could not find"))
                {
                    result = "Host found";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }
    }
}

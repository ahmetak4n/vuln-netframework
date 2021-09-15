using System;
using System.Diagnostics;

namespace DI.Services
{
    public class OsCommandInjectionService : IOsCommandInjectionService
    {
        #region Classic
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

        public string Classic2(string command)
        {
            string result = "";

            try
            {
                var process = Process.Start(command);
                process.StartInfo.RedirectStandardOutput = true;

                result = process.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Classic3(string command)
        {
            string result = "";

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = command;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.RedirectStandardOutput = false;
                process.Start();

                result = process.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string ClassicWithPython(string command)
        {
            string result = "";

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = @"python3.exe";
                process.StartInfo.Arguments = command;
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

        #endregion

        #region Blind
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
        #endregion
    }
}

using System;
using System.Diagnostics;

namespace DI.Services
{
    public class OsCommandInjectionService : IOsCommandInjectionService
    {
        #region Classic
        public string Classic(string command, string arguments)
        {
            string result = "";

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = command;
                process.StartInfo.Arguments = arguments;
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

        public string ClassicWithProcessStartInfo(string command, string arguments)
        {
            string result = "";

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };

                var process = Process.Start(processStartInfo);
                result = process.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Classic2(string ip)
        {
            string result = "";

            try
            {
                Process process = new Process();

                process.StartInfo.FileName = @"cmd.exe";
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

        public string Classic2WithProcessStartInfo(string ip)
        {
            string result = "";

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = @"cmd.exe",
                    Arguments = "/c ping " + ip,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };

                var process = Process.Start(processStartInfo);
                result = process.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string ClassicWithPython(string arguments)
        {
            string result = "";

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = @"python3.exe";
                process.StartInfo.Arguments = "-c \"" + arguments + "\"";
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
            string result = "Command was worked";

            try
            {
                Process.Start(command);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string BlindWithArguments(string command, string arguments)
        {
            string result = "Command was worked";

            try
            {
                Process.Start(command, arguments);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Blind2(string command)
        {
            string result = "Command was worked";

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = command;
                process.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Blind2WithProcessStartInfo(string command)
        {
            string result = "Command was worked";

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = command
                };

                Process.Start(processStartInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Blind3(string command, string arguments)
        {
            string result = "Command was worked";

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = command;
                process.StartInfo.Arguments = arguments;
                process.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Blind3WithProcessStartInfo(string command, string arguments)
        {
            string result = "Command was worked";

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = arguments
                };

                Process.Start(processStartInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public string Blind4(string host)
        {
            string result = "Host not found";
            try
            {
                Process process = new Process();

                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c ping " + host;
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

        public string Blind4WithProcessStartInfo(string host)
        {
            string result = "Host not found";
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c ping " + host,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };

                var console = Process.Start(processStartInfo).StandardOutput.ReadToEnd();

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

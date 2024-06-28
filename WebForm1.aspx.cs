using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web.ModelBinding;
using System.Web.Script.Serialization;
using System.Web.Services;
using WebApplication5.Database;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string Restart(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION1(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION2(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION3(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION4(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION5(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION6(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION7(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION8(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION9(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION10(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION11(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string RestartSTATION12(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/r /m \\\\{ipAddress} /t 10 /f /c \"Scheduled restart\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing restart command for {ipAddress}: {error}";
                    }
                }

                return "Restart initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string Shutdown(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue; 
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION1(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION2(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION3(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION4(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION5(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION6(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION7(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION8(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION9(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION10(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION11(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        [WebMethod]
        public static string ShutdownSTATION12(string[] ipAddresses)
        {
            try
            {
                if (ipAddresses == null || ipAddresses.Length == 0)
                {
                    return "Error: No IP addresses provided.";
                }

                foreach (string ipAddress in ipAddresses)
                {
                    if (string.IsNullOrEmpty(ipAddress))
                    {
                        continue;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"/s /m \\\\{ipAddress} /t 10 /f /c \"Scheduled shutdown\"")
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    Process process = Process.Start(psi);
                    process.WaitForExit();

                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode != 0)
                    {
                        return $"Error executing shutdown command for {ipAddress}: {error}";
                    }
                }

                return "Shutdown initiated for all specified IP addresses";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public class ModelVariantData
        {
            public string ModelName { get; set; }
            public string VariantName { get; set; }
        }
        [WebMethod]
        public static string DOWNLOADREPORT(string variant,  string Model,string from, string to)
        {
            using (HimanshuEntities db = new HimanshuEntities())
            {
                DateTime fromDate = DateTime.Parse(from);
                DateTime toDate = DateTime.Parse(to);
                var res = db.SaveDatas
                            .Where(i => i.ModelName== Model && i.VarientName == variant && i.QR_PrintTIME >= fromDate && i.QR_PrintTIME <= toDate)
                            .Select(i => new SaveData
                            {
                                ID = i.ID,
                                ModelName = i.ModelName,
                                VarientName = i.VarientName,
                                QR_Data = i.QR_Data,
                                Status = i.Status,
                                QR_PrintTIME = i.QR_PrintTIME,
                            }).ToList();

                return new JavaScriptSerializer().Serialize(res);
            }
        }
    
    [WebMethod]
        public static List<string> GetModels()
        {
            using (HimanshuEntities db = new HimanshuEntities())
            { 
             var res = db.SaveDatas.Select(i=>i.ModelName).ToList();
                return res;
            }
        }
        [WebMethod]
        public static List<string> GetVariants(string model)
        {
            using (HimanshuEntities db = new HimanshuEntities())
            {
                var res = db.SaveDatas.Where(i => i.ModelName == model).Select(i => i.VarientName).ToList();
                return res;
            }
        }

    }
}

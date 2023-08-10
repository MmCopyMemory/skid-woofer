using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.IO;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace skid_woofer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Main:
            Console.Clear();
            Console.Title = settings.title;
            Console.WriteLine(settings.banner);
            Console.WriteLine("Professionally skidded by deactivated.");
            Console.WriteLine("[1] > SPOOF");
            Console.WriteLine("[2] > CLEAN");
            Console.WriteLine("[3] > CHECK");
            var keey = Console.ReadKey();
            switch (keey.Key)
            {
                case ConsoleKey.D1:
                    if (settings.amidewinbatch == "")
                    {
                        try
                        {
                            WebClient webClient = new WebClient();
                            webClient.DownloadFile(settings.mapper, "C:\\Windows\\IME\\mapper.exe");
                            webClient.DownloadFile(settings.driver, "C:\\Windows\\IME\\driver.sys");
                            Process process = new Process();
                            process.StartInfo.FileName = "cmd.exe";
                            process.StartInfo.UseShellExecute = true;
                            process.StartInfo.CreateNoWindow = true;
                            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            Process process2 = Process.Start("C:\\Windows\\IME\\mapper.exe", "C:\\Windows\\IME\\driver.sys");
                            Task.Delay(1000).GetAwaiter().GetResult();
                            process2.Close();
                            File.Delete("C:\\Windows\\IME\\driver.sys");
                            File.Delete("C:\\Windows\\IME\\mapper.exe");
                            Console.WriteLine("spoofed.");
                            Task.Delay(1000).GetAwaiter().GetResult();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception: {ex}");
                        }
                        goto Main;
                    } else
                    {
                        try
                        {
                            WebClient wc = new WebClient();
                            wc.DownloadFile(settings.driver, settings.driverfile);
                            wc.DownloadFile(settings.mapper, settings.mapperfile);
                            wc.DownloadFile(settings.amidewinbatch, settings.mapperbatch);
                            Process.Start(settings.mapperbatch);
                            Task.Delay(1000).GetAwaiter().GetResult();
                            File.Delete(settings.driverfile);
                            File.Delete(settings.mapperfile);
                            File.Delete(settings.mapperbatch);
                            Console.WriteLine("Restart please.");
                            Task.Delay(1000).GetAwaiter().GetResult();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception: {ex}");
                            Task.Delay(1000).GetAwaiter().GetResult();
                        }
                        goto Main;
                    }
                break;
                case ConsoleKey.D2:
                    try
                    {
                        WebClient wbc = new WebClient();
                        wbc.DownloadFile(settings.cleaner, settings.cleanerfile);
                        Process.Start(settings.cleanerfile);
                        Console.WriteLine("Cleaner running in background...");
                        Task.Delay(1000).GetAwaiter().GetResult();
                    } catch (Exception ex)
                    {
                        Console.WriteLine($"Exception: {ex}");
                    }
                    goto Main;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Disk Drive");
                    GetWMICProperty("Win32_DiskDrive", "Model");
                    GetWMICProperty("Win32_DiskDrive", "SerialNumber");
                    Console.WriteLine();
                    Console.WriteLine("CPU");
                    GetWMICProperty("Win32_Processor", "SerialNumber");
                    Console.WriteLine();
                    Console.WriteLine("BIOS");
                    GetWMICProperty("Win32_BIOS", "SerialNumber");
                    Console.WriteLine();
                    Console.WriteLine("Motherboard");
                    GetWMICProperty("Win32_BaseBoard", "SerialNumber");
                    Console.WriteLine();
                    Console.WriteLine("smBIOS UUID");
                    GetWMICProperty("Win32_ComputerSystemProduct", "UUID");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press enter to go back...");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                    { }
                    goto Main;
                    break;
            }
        }
        static void GetWMICProperty(string className, string propertyName)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + className); foreach (ManagementObject obj in searcher.Get()) { Console.WriteLine(obj[propertyName]); }
        }
    }
}

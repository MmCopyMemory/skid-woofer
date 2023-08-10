using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skid_woofer
{
    internal class settings
    {
        public static string driver = "https://secwin.lol/idk59959/amidewinx64_2.exe"; //AMIDEWIN
        public static string mapper = "https://secwin.lol/idk59959/amifldrv64_2.sys"; //AMIDEWIN
        public static string amidewinbatch = "https://secwin.lol/skidwoofer/run.bat"; //REMOVE TO RUN MAPPER WITH DRIVER INSTEAD OF BATCH
        public static string cleaner = "https://secwin.lol/idk59959/deepp_cleaner.exe"; //Cleenor
        public static string cleanerfile = "C:\\Windows\\DpCl.exe";                     //Idk
        public static string driverfile = "C:\\Windows\\amifldrv64.sys";              //THIS ONLY GETS USED IF AMIDEWINBATCH IS NOT EMPTY
        public static string mapperfile = "C:\\Windows\\AMIDEWINx64.EXE";             //THIS ONLY GETS USED IF AMIDEWINBATCH IS NOT EMPTY
        public static string mapperbatch = "C:\\Windows\\r.bat";                      //THIS ONLY GETS USED IF AMIDEWINBATCH IS NOT EMPTY
        public static string title = "SkidWare";                                      //CONSOLE TITLLE
        public static string banner = @".▄▄ · ▄ •▄ ▪  ·▄▄▄▄  ▄▄▌ ▐ ▄▌ ▄▄▄· ▄▄▄  ▄▄▄ .
▐█ ▀. █▌▄▌▪██ ██▪ ██ ██· █▌▐█▐█ ▀█ ▀▄ █·▀▄.▀·
▄▀▀▀█▄▐▀▀▄·▐█·▐█· ▐█▌██▪▐█▐▐▌▄█▀▀█ ▐▀▀▄ ▐▀▀▪▄
▐█▄▪▐█▐█.█▌▐█▌██. ██ ▐█▌██▐█▌▐█ ▪▐▌▐█•█▌▐█▄▄▌
 ▀▀▀▀ ·▀  ▀▀▀▀▀▀▀▀▀•  ▀▀▀▀ ▀▪ ▀  ▀ .▀  ▀ ▀▀▀ 
";                                                                                    //BANNER
    }
}

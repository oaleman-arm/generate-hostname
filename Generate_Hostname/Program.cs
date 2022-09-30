using System;
using System.Management;




namespace Generate_Hostname
{
    class Program
    {
        static void Main(string[] args)
        {
            string device = "";
            string account = "";
            Console.WriteLine("*************************************");
            Console.WriteLine("GENERADOR DE HOSTNAME \r");
            Console.WriteLine("*************************************\n");


            Console.WriteLine("ESCOGE EL TIPO DE DISPOSITIVO:");
            Console.WriteLine("\t1 - LAPTOP");
            Console.WriteLine("\t2 - DESKTOP");
            Console.Write("TU OPCION: ");
      
            switch (Console.ReadLine())
            {

                case "1":
                    account = GetAccount();
                    if (account != "")
                    {
                        device = "L";
                        Console.WriteLine("\n");
                        Console.Write("N" + device + account + GenerateSerial());
                        Console.WriteLine("\n");
                        Console.Write("Press any key to close the console app...");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Escoja una opcion valida");
                        Console.WriteLine("\n");
                        Console.Write("Press any key to close the console app...");
                        Console.ReadKey();
                    }
                    break;

                case "2":
                    account = GetAccount();
                    if (account != "") {
                    device = "D";
                        Console.WriteLine("\n");
                        Console.Write("N" + device + account + GenerateSerial());
                        Console.WriteLine("\n");
                        Console.Write("Press any key to close the console app...");
                    Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Escoja una opcion valida");
                        Console.WriteLine("\n");
                        Console.Write("Press any key to close the console app...");
                        Console.ReadKey();
                    }
                    break;

                default:
                    Console.WriteLine("Escoja una opcion valida");
                    Console.WriteLine("\n");
                    Console.Write("Press any key to close the console app...");
                    Console.ReadKey();
                    break;
            }
        }

        static public string GenerateSerial()
        {
            string serial = "";
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BIOS");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serial = getserial["SerialNumber"].ToString();
            }
            return serial;
        }

        static public string GetAccount()
        {
            string account = "";
            Console.WriteLine("Escoge la cuenta:");
            Console.WriteLine("\t1 - ADMINISTRACION");
            Console.WriteLine("\t2 - 4CHANGE");
            Console.WriteLine("\t3 - TXU ENERGY");
            Console.WriteLine("\t4 - AKYTA");
            Console.WriteLine("\t5 - INTERMEDIA");
            Console.WriteLine("\t6 - WALMART");
            Console.WriteLine("\t7 - MEDIA CONTROLLERS");
            Console.WriteLine("\t8 - TRAINING ROOMS");
            Console.WriteLine("\t9 - MONITOREO");
            Console.WriteLine("\t10 - CASH APP");
            Console.WriteLine("\t11 - SOFI");
            Console.WriteLine("\t12 - ENFERMERIA");
            Console.WriteLine("\t13 - ZWIFT");
            Console.WriteLine("\t14 - SPIN");
            Console.Write("Tu escogiste: ");
        
            switch (Console.ReadLine())
            {

                case "1":
                    account = "ADM";
                    break;
                 
                case "2":
                    account = "4CH";
                    break;

                case "3":
                    account = "TXU";
                    break;

                case "4":
                    account = "AKY";
                    break;

                case "5":
                    account = "INT";
                    break;

                case "6":
                    account = "WMT";
                    break;

                case "7":
                    account = "CTR";
                    break;

                case "8":
                    account = "TRN";
                    break;

                case "9":
                    account = "MON";
                    break;

                case "10":
                    account = "CAP";
                    break;

                case "11":
                    account = "SFI";
                    break;

                case "12":
                    account = "ENF";
                    break;

                case "13":
                    account = "ZWT";
                    break;

                case "14":
                    account = "SPN";
                    break;
                default:
                    account = "";
                break;
            }
            return account;

        }
    }
}

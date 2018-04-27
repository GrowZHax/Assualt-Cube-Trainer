using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static int Base = 0x00509b74;
        public static int Health = 0xF8;
        public static int SniperAmmo = 0x14c;

        static void Main(string[] args)
        {
            VAMemory vam = new VAMemory("ac_client");
            Console.Write("Assault Cube Founded !");
            int LocalPlayer = vam.ReadInt32((IntPtr)0x00509b74);
            while (true)
            {
                int address = LocalPlayer + Health;
                vam.WriteInt32((IntPtr)address, 12341);

                address = LocalPlayer + SniperAmmo;
                vam.WriteInt32((IntPtr)address, 12341);
            }
        }
    }
}
    
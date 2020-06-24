using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy.Core
{
    public static class Cartridge
    {

        private static byte[] ROM;

        public static void FillROM(byte[] data)
        {
            ROM = data;
        }

        public static byte ReadByte(int PC)
        {
            if(PC < ROM.Length)
                return ROM[PC];
            return 0;
        }

        public static int GetROMLength()
        {
            return ROM.Length;
        }

    }
}

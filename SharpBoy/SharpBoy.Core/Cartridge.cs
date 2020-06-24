using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy.Core
{
    public class Cartridge
    {

        private byte[] ROM;

        public void FillROM(byte[] data)
        {
            ROM = data;
        }

        public byte ReadInstruction(int PC)
        {
            if(PC < ROM.Length)
                return ROM[PC];
            return 0;
        }

        public int GetROMLength()
        {
            return ROM.Length;
        }

    }
}

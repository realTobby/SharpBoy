using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy.GameBoy
{
    public class CPURegisters
    {
        public AF RegisterAF;
        public BC RegisterBC;
        public DE RegisterDE;
        public HL RegisterHL;
        public byte SP;
        public ushort PC;

        public CPURegisters()
        {
            PC = 0x0100;
        }
    }

    public struct FLAGS
    {
        public byte Z;
        public byte N;
        public byte H;
        public byte C;
    }

    public struct AF
    {
        public byte A;
        public byte F;
    }

    public struct BC
    {
        public byte B;
        public byte C;
    }

    public struct DE
    {
        public byte D;
        public byte E;
    }

    public struct HL
    {
        public byte H;
        public byte L;
    }
}

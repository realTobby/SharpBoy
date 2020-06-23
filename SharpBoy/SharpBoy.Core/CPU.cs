using System;

namespace SharpBoy.Core
{
    // Sharp LR35902

    // Register
    /* A => Accumulator
     * F => Flagregister
     * B
     * C
     * D
     * E
     * H
     * L
     */


    // BootROM + ROM + VRAM + EXTRAM + RAM + OAMRAM + I/O + HRAM


    public class CPU
    {
        byte A;
        byte F;
        byte B;
        byte C;
        byte D;
        byte E;
        byte H;
        byte L;

        byte[] rom;
        byte[] vram;
        byte[] extram;
        byte[] ram;
        byte[] oaram;
        byte[] input;
        byte[] hram;


        int programCounter; // => points to the next instruction
        int stackPointer; // => points to the next unused space in the stack

        public void Rotate()
        {

        }

        public void Swap()
        {

        }

        public void Test()
        {

        }

        public void Set()
        {
            
        }

        public void Reset()
        {

        }


    }
}

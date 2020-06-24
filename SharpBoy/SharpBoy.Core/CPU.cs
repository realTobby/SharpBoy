using System;
using System.Security.Cryptography;

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
        public CPURegisters _cpuRegisters;

        public int _cycleCounter = 0;

        public CPU()
        {
            _cpuRegisters = new CPURegisters(){};
        }


        public void HandleInstrcution(byte instrcution)
        {

            int bytes = 1;

            switch (instrcution)
            {
                #region LD nn,n
                case 0x06: // LD_B_n
                    _cpuRegisters.B = Cartridge.ReadByte(_cpuRegisters.PC + 1);
                    bytes += 1;
                    _cycleCounter += 8;
                    break;
                case 0x0E: // LD_C_n
                    _cpuRegisters.C = Cartridge.ReadByte(_cpuRegisters.PC + 1);
                    bytes += 1;
                    _cycleCounter += 8;
                    break;
                case 0x16: // LD_D_n
                    _cpuRegisters.D = Cartridge.ReadByte(_cpuRegisters.PC + 1);
                    bytes += 1;
                    _cycleCounter += 8;
                    break;
                case 0x1E: // LD_E_n
                    _cpuRegisters.E = Cartridge.ReadByte(_cpuRegisters.PC + 1);
                    bytes += 1;
                    _cycleCounter += 8;
                    break;
                case 0x26: // LD_H_n
                    _cpuRegisters.H = Cartridge.ReadByte(_cpuRegisters.PC + 1);
                    bytes += 1;
                    _cycleCounter += 8;
                    break;
                case 0x2E: // LD_L_n
                    _cpuRegisters.L = Cartridge.ReadByte(_cpuRegisters.PC + 1);
                    bytes += 1;
                    _cycleCounter += 8;
                    break;
                #endregion

                #region  LD r1, r2
                case 0x7F:
                    _cpuRegisters.A = _cpuRegisters.A;
                    _cycleCounter += 4;
                    break;
                case 0x78:
                    _cpuRegisters.A = _cpuRegisters.B;
                    _cycleCounter += 4;
                    break;
                case 0x79:
                    _cpuRegisters.A = _cpuRegisters.C;
                    _cycleCounter += 4;
                    break;
                case 0x7A:
                    _cpuRegisters.A = _cpuRegisters.D;
                    _cycleCounter += 4;
                    break;
                case 0x7B:
                    _cpuRegisters.A = _cpuRegisters.E;
                    _cycleCounter += 4;
                    break;
                case 0x7C:
                    _cpuRegisters.A = _cpuRegisters.H;
                    _cycleCounter += 4;
                    break;
                case 0x7D:
                    _cpuRegisters.A = _cpuRegisters.L;
                    _cycleCounter += 4;
                    break;
                case 0x7E:
                    // _cpuRegisters.A = _cpuRegisters.HL; => how to get 16bit value into 8 bit register???
                    _cycleCounter += 8;
                    break;
                case 0x40:

                    break;
                #endregion

                default:
                    Console.WriteLine("Unsopprted OPCODE! ==> " + instrcution);
                    break;
            }
            _cpuRegisters.PC = _cpuRegisters.PC + bytes;
        }




    }
}

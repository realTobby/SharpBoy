using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy.GameBoy
{
    public class CPU
    {
        private CPURegisters _cpuRegisters;
        private Cartridge _cartridge;
        public CPU()
        {
            _cpuRegisters = new CPURegisters();
            _cartridge = new Cartridge("tetris.gb");
        }

        public void Tick()
        {
            var opcode = _cartridge.ReadByte(_cpuRegisters.PC);
            string hexOpCode = opcode.ToString("X");
            Console.Write("[" + hexOpCode + "] ");
            switch(opcode)
            {
                case 0x00: // NOP
                    Console.WriteLine("Instruction: NOP");
                    _cpuRegisters.PC += 1;
                    break;

                case 0xC3: // JP nn
                    var address = _cartridge.ReadByte(_cpuRegisters.PC + 1);
                    Console.WriteLine("JMP TO : " + address);
                    _cpuRegisters.PC = address;
                    break;

                default:
                    Console.WriteLine("UNSUPPORTED INSTRUCTION => 0x" + hexOpCode);
                    _cpuRegisters.PC += 1;
                    break;
            }
        }

    }
}

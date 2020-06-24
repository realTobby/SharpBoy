
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpBoy.Core
{

    // ALL OF THE COMPONENT CLASSES WILL BE USED INSIDE HERE ==> DMGCPU HANDLES EVERYTHING (MOTHERBOARD IF YOU WILL)
    /* BootROM
     * CPU
     * Input
     * InteruptController
     * Memory
     * PixelProcessingUnit
     * SerialDataTransfer
     * SoundController
     * Timer
     * */
    public class DMG
    {

        CPU _cpu;
        BootROM _bootROM;
        Input _input;
        InteruptController _interuptController;
        Memory _memory;
        PixelProcessingUnit _pixelProcessingUnit;
        SerialDataTransfer _serialDataTransfer;
        SoundController _soundController;
        Timer _timer;
        public void Init()
        {
            _cpu = new CPU();
            _bootROM = new BootROM();
            _input = new Input();
            _interuptController = new InteruptController();
            _memory = new Memory();
            _pixelProcessingUnit = new PixelProcessingUnit();
            _serialDataTransfer = new SerialDataTransfer();
            _soundController = new SoundController();
            _timer = new Timer();

        }

        public void LoadROM()
        {
            byte[] data = _bootROM.GetBIOS();
            Cartridge.FillROM(data);
        }

        public void LoadROM(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            Cartridge.FillROM(data);
        }

        public void EmulateNextInstruction()
        {
            var nextOpcode = Cartridge.ReadByte(_cpu._cpuRegisters.PC);
            Console.WriteLine("BYTE: " + nextOpcode);
            _cpu.HandleInstrcution(nextOpcode);
            Console.WriteLine("Cycles: " + _cpu._cycleCounter);
        }

        public bool HasInstructionsLeft()
        {
            if (_cpu._cpuRegisters.PC >= Cartridge.GetROMLength())
                return false;
            return true;
        }
    }
}

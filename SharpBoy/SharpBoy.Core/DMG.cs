
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
        Cartridge _cartridge;
        BootROM _bootROM;
        Input _input;
        InteruptController _interuptController;
        Memory _memory;
        PixelProcessingUnit _pixelProcessingUnit;
        SerialDataTransfer _serialDataTransfer;
        SoundController _soundController;
        Timer _timer;

        InstructionHandler _instructionHandler;

        public void Init()
        {
            _cpu = new CPU();
            _cartridge = new Cartridge();
            _bootROM = new BootROM();
            _input = new Input();
            _interuptController = new InteruptController();
            _memory = new Memory();
            _pixelProcessingUnit = new PixelProcessingUnit();
            _serialDataTransfer = new SerialDataTransfer();
            _soundController = new SoundController();
            _timer = new Timer();

            _instructionHandler = new InstructionHandler();
        }

        public void LoadROM()
        {
            byte[] data = _bootROM.GetBIOS();
            _cartridge.FillROM(data);
        }

        public void LoadROM(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            _cartridge.FillROM(data);
        }

        public void EmulateNextInstruction()
        {
            var nextOpcode = _cartridge.ReadInstruction(_cpu.ProgramCounter);
            Console.WriteLine("BYTE: " + nextOpcode);
            _instructionHandler.HandleInstrcution(nextOpcode);
            _cpu.ProgramCounter++;
        }

        public bool HasInstructionsLeft()
        {
            if (_cpu.ProgramCounter >= _cartridge.GetROMLength())
                return false;
            return true;
        }
    }
}

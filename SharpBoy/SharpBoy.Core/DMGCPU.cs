
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy.Core
{

    // ALL OF THE COMPONENT CLASSES WILL BE USED INSIDE HERE ==> DMGCPU HANDLES EVERYTHING ELSE
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
    public class DMGCPU
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

        public void Startup()
        {
            _memory.Foo(_bootROM.GetBIOS());
        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpBoy.Core
{

    // THIS IS THE INITAL STARTUP OF THE GAMEBOY

    // RESET + LOGO + RING TONE

    // Init RAM => Init Sound => Set up Logo => Scroll Logo => Play Sound => Scroll Logo => Decode Logo => Logo data => Compare Logo => Checksum header => Turn off ROM

    public class BootROM
    {
        public byte[] GetBIOS()
        {
            // this is debug => the path of the bios boot rom will change eventually

            return File.ReadAllBytes("../../../../../gbBootROM.gb");

        }


    }
}

using SFML.Graphics;
using SharpBoy.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy
{
    public class Emulator
    {
        DMG _dmgMain;

        public void Start()
        {
            _dmgMain = new DMG();
            Logging.Log("Starting SharpBoy...", Severity.Information);

            _dmgMain.Init();
            Logging.Log("Initializing components...", Severity.Information);
            GameBoyWindow gbw = new GameBoyWindow();
            gbw.Init();
            Logging.Log("Creating GameBoy window...", Severity.Information);
            //_dmgMain.LoadROM(@"C:\Users\tkatt\Desktop\tetris.gb");
            
            while (gbw.gameboyWindow.IsOpen)
            {
                gbw.gameboyWindow.Clear();
                gbw.gameboyWindow.DispatchEvents();
                gbw.gameboyWindow.Display();

                if(_dmgMain.HasInstructionsLeft())
                    Tick();

            }
        }

        public void Tick()
        {
            _dmgMain.EmulateNextInstruction();
        }

    }
}

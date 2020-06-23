using SFML.Graphics;
using SharpBoy.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy
{
    public class Emulator
    {
        DMG _components;

        public void Start()
        {
            _components = new DMG();
            Logging.Log("Starting SharpBoy...", Severity.Information);

            _components.Init();
            Logging.Log("Initializing components...", Severity.Information);
            GameBoyWindow gbw = new GameBoyWindow();
            gbw.Init();
            Logging.Log("Creating GameBoy window...", Severity.Information);
            _components.Startup();
            
            while (gbw.gameboyWindow.IsOpen)
            {
                gbw.gameboyWindow.Clear();
                gbw.gameboyWindow.DispatchEvents();
                gbw.gameboyWindow.Display();

                Tick();

            }
        }

        public void Tick()
        {



        }

    }
}

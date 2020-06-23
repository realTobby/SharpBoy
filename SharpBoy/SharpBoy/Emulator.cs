using SFML.Graphics;
using SharpBoy.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy
{
    public class Emulator
    {
        DMGCPU _components;

        public void Start()
        {
            _components = new DMGCPU();

            _components.Init();

            GameBoyWindow gbw = new GameBoyWindow();
            gbw.Init();

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

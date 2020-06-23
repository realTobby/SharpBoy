using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy
{
    public class Emulator
    {

        public void Start()
        {
            GameBoyWindow gbw = new GameBoyWindow();
            gbw.Init();

            CircleShape cs = new CircleShape(100.0f);
            cs.FillColor = Color.Green;

            while (gbw.gameboyWindow.IsOpen)
            {
                gbw.gameboyWindow.Clear();
                gbw.gameboyWindow.DispatchEvents();
                gbw.gameboyWindow.Draw(cs);
                gbw.gameboyWindow.Display();

                Tick();

            }
        }

        public void Tick()
        {



        }

    }
}

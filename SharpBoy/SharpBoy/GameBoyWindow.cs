using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML;
using SFML.Graphics;
using SFML.Window;

namespace SharpBoy
{
    public class GameBoyWindow
    {
        public RenderWindow gameboyWindow;
        public void Init()
        {
            gameboyWindow = new RenderWindow(new VideoMode(160, 144), "SharpBoy");
            gameboyWindow.SetActive();
        }


    }
}

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
        public void Start()
        {
            RenderWindow window = new RenderWindow(new VideoMode(160, 144), "test");
            CircleShape cs = new CircleShape(100.0f);
            cs.FillColor = Color.Green;
            window.SetActive();
            while (window.IsOpen)
            {
                window.Clear();
                window.DispatchEvents();
                window.Draw(cs);
                window.Display();
            }
        }


    }
}

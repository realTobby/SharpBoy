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
        public float videoOutputScale = 4.0f;   // Scalefactor for Output Video 

        public void Init()
        {
            gameboyWindow = new RenderWindow(new VideoMode((uint)(160 * videoOutputScale), (uint)(144 * videoOutputScale)), "SharpBoy", Styles.Close);
            gameboyWindow.SetActive();

            gameboyWindow.KeyPressed += Window_KeyPressed;
            gameboyWindow.Closed += Window_Closed;
        }

        private void Window_KeyPressed(object sender, SFML.Window.KeyEventArgs e)
        {
            var window = (SFML.Window.Window)sender;
            if (e.Code == SFML.Window.Keyboard.Key.Escape)
            {
                
            }
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            var window = (SFML.Window.Window)sender;
                window.Close();
        }
    }
}

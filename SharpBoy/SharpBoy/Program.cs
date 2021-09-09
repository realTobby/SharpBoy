using SFML.Graphics;
using SFML.Window;
using SharpBoy.GameBoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBoy
{
    class Program
    {
        static RenderWindow _window;

        static void Main(string[] args)
        {
            CPU gameboyCPU = new CPU();

            Console.WriteLine("==================");

            _window = new RenderWindow(new VideoMode(160, 144), "SharpBoy by github.com/realTobby");
            _window.SetVisible(true);
            _window.Closed += new EventHandler(OnClosed);
            while (_window.IsOpen)
            {
                _window.DispatchEvents();
                _window.Clear(Color.Red);

                gameboyCPU.Tick();




                _window.Display();
            }

        }

        static void OnClosed(object sender, EventArgs e)
        {
            _window.Close();
        }
    }
}

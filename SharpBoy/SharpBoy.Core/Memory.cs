using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy.Core
{
    // window map => 1kb
    // background map => 1kb
    // background tiles => 4kb
    // sprites tiles => 4kb


    public class Memory
    {
        public void Foo(byte[] bytes)
        {
            Logging.Log("Showing BIOS bytes", Severity.Error);

            foreach(byte b in bytes)
            {
                Console.WriteLine(b.ToString("x8"));
            }
        }




    }
}

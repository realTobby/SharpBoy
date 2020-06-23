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
            Console.WriteLine(BitConverter.ToString(bytes));

            foreach (byte b in bytes)
            {
                
            }
        }




    }
}

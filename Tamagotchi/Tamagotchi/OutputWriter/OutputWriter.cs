using System;

namespace Tamagotchi
{
    class OutputWriter : IOutputWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}

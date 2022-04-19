using System;

namespace Tamagotchi
{
    class InputReader : IInputReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}

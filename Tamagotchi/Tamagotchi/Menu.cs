using System;

namespace Tamagotchi
{
    public class Menu
    {
        private readonly ITamagotchiClass _tamagotchi;
        private readonly IOutputWriter _outputWriter;
        private readonly IInputReader _inputReader;

        public Menu(ITamagotchiClass Tamagotchi, IOutputWriter OutputWriter, IInputReader InputReader)
        {
            _tamagotchi = Tamagotchi;
            _outputWriter = OutputWriter;
            _inputReader = InputReader;
        }
        public void StartGame()
        {
            _outputWriter.Write("Witaj w grze Tamagotchi.");
            while(true)
            {
                _outputWriter.Write("Wybierz, co chcesz zrobić.");
                _outputWriter.Write("1. Jedz.");
                _outputWriter.Write("2. Śpij.");
                _outputWriter.Write("3. Graj z Tamagotchi.");
                _outputWriter.Write("4. Zabij Tamagotchi.");
                switch (_inputReader.Read())
                {
                    case "1":
                        if (!_tamagotchi.Eat()) return;
                        break;
                    case "2":
                        if (!_tamagotchi.Sleep()) return;
                        break;
                    case "3":
                        if (!_tamagotchi.Play()) return;
                        break;
                    case "4":
                        _outputWriter.Write("Tamagotchi jest martwe.");
                        return;
                    default:
                        _outputWriter.Write("Prosze poprawnie wybrać komendę.");
                        break;
                }
                _inputReader.Read();
                Console.Clear();
            }
        }
    }
}

namespace Tamagotchi
{
    public class Listener : IListener
    {
        private readonly IOutputWriter _outputWriter;
        public Listener(IOutputWriter OutputWriter)
        {
            _outputWriter = OutputWriter;
        }
        public bool CheckIfAllive(TamagotchiStatus status)
        {
            if (status.Hunger == 10 || status.Energy == 0 || status.Happiness == 0)
            {
                _outputWriter.Write("Tamagotchi zdechło.");
                return false;
            }
            _outputWriter.Write("Głód Tamagotchi: " + status.Hunger);
            _outputWriter.Write("Energia Tamagotchi: " + status.Energy);
            _outputWriter.Write("Szczęście Tamagotchi: " + status.Happiness);
            return true;
        }
        public bool CheckIfCanEat(TamagotchiStatus status)
        {
            if(status.Hunger == 0)
            {
                _outputWriter.Write("Nie można nakarmić Tamagotchi, ponieważ jest przejedzone.");
                return false;
            }
            return true;
        }
        public bool CheckIfCanSleep(TamagotchiStatus status)
        {
            if (status.Energy == 10)
            {
                _outputWriter.Write("Tamagotchi nie może iść spać, ponieważ jest w pełni wyspane.");
                return false;
            }
            return true;
        }
        public bool CheckIfCanPlay(TamagotchiStatus status)
        {
            if (status.Happiness == 10)
            {
                _outputWriter.Write("Tamagotchi nie może się bawić, ponieważ ");
                return false;
            }
            return true;
        }
    }
}

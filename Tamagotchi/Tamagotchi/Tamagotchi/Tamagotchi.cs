namespace Tamagotchi
{
    public class TamagotchiClass : ITamagotchiClass
    {
        private readonly IListener _listener;
        private readonly TamagotchiStatus _status;

        public TamagotchiClass(IListener listener, TamagotchiStatus status)
        {
            _listener = listener;
            _status = status;
        }

        public bool Eat()
        {
            if (PublishStatus(1))
            {
                _status.Hunger--;
            }
            return PublishStatus(4);
        }

        public bool Play()
        {
            if (PublishStatus(2))
            {
                _status.Energy--;
                _status.Hunger++;
                _status.Happiness++;
            }
            return PublishStatus(4);
        }
        public bool Sleep()
        {
            if (PublishStatus(3))
            {
                _status.Energy++;
                _status.Hunger++;
                _status.Happiness--;
            }
            return PublishStatus(4);
        }
        public bool PublishStatus(int i)
        {
            switch (i)
            {
                case 1:
                    return _listener.CheckIfCanEat(_status);
                case 2:
                    return _listener.CheckIfCanPlay(_status);
                case 3:
                    return _listener.CheckIfCanSleep(_status);
                case 4:
                    return _listener.CheckIfAllive(_status);
            }
            return false;
        }
    }
}

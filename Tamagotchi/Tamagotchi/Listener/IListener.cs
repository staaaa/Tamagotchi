namespace Tamagotchi
{
    public interface IListener
    {
        public bool CheckIfAllive(TamagotchiStatus status);
        public bool CheckIfCanEat(TamagotchiStatus status);
        public bool CheckIfCanSleep(TamagotchiStatus status);
        public bool CheckIfCanPlay(TamagotchiStatus status);
    }
}

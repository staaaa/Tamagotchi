namespace Tamagotchi
{
    public interface ITamagotchiClass
    {
        public bool Eat();
        public bool Sleep();
        public bool Play();
        public bool PublishStatus(int i);
    }
}

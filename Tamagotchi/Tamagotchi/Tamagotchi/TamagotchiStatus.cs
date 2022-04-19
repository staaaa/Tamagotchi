namespace Tamagotchi
{
    public class TamagotchiStatus
    {
        public int Energy { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public TamagotchiStatus(int energy, int hunger, int happiness)
        {
            Energy = energy;
            Hunger = hunger;
            Happiness = happiness;
        }
    }
}

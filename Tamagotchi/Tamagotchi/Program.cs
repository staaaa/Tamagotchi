namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m1 = new Menu(new TamagotchiClass(new Listener(new OutputWriter()), new TamagotchiStatus(5,0,5)), new OutputWriter(), new InputReader());
            m1.StartGame();
        }
    }
}

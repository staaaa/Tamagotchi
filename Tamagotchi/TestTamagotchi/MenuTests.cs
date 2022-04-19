using NSubstitute;
using NUnit.Framework;
using Tamagotchi;

namespace TestTamagotchi
{
    public class MenuTests
    {
        [Test]
        public void Check_If_Tamagotchi_Eats_When_Its_Supposed_To()
        {
            var outputWriter = Substitute.For<IOutputWriter>();
            var inputReader = Substitute.For<IInputReader>();
            var tamagotchi = Substitute.For<ITamagotchiClass>();

            inputReader.Read().Returns("1");

            var menu = new Menu(tamagotchi, outputWriter, inputReader);

            menu.StartGame();
            tamagotchi.Received().Eat();
        }
        [Test]
        public void Check_If_Tamagotchi_Eats_When_Its_NOT_Supposed_To()
        {
            var outputWriter = Substitute.For<IOutputWriter>();
            var inputReader = Substitute.For<IInputReader>();
            var tamagotchi = Substitute.For<ITamagotchiClass>();

            inputReader.Read().Returns("2");

            var menu = new Menu(tamagotchi, outputWriter, inputReader);

            menu.StartGame();
            tamagotchi.DidNotReceive().Eat();
        }
    }
}

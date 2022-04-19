using NSubstitute;
using NUnit.Framework;
using Tamagotchi;

namespace TestTamagotchi
{
    public class TamagotchiTests
    {
        [Test]
        public void Is_Check_If_Can_Eat_Called()
        {
            var listener = Substitute.For<IListener>();
            var status = new TamagotchiStatus(2,2,2);
            var tamagotchi = new TamagotchiClass(listener, status);

            tamagotchi.Eat();
            listener.Received().CheckIfCanEat(Arg.Any<TamagotchiStatus>());
        }
    }
}

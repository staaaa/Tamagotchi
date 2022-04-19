using NSubstitute;
using NUnit.Framework;
using Tamagotchi;

namespace TestTamagotchi
{
    public class ListenerTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(6, 4, 8)]
        [TestCase(2, 0, 2)]
        [TestCase(1, 9, 1)]
        [TestCase(10, 0, 10)]
        public void Check_If_Allive_When_Allive(int energy, int hunger, int happiness)
        {
            var outputWriter = Substitute.For<IOutputWriter>();
            var listener = new Listener(outputWriter);
            Assert.IsTrue(listener.CheckIfAllive(new TamagotchiStatus(energy, hunger, happiness)));
        }
        [TestCase(0,10,0)]
        [TestCase(0,10,2)]
        [TestCase(5,1,0)]
        [TestCase(10, 10, 10)]
        public void Check_If_Allive_When_Dead(int energy, int hunger, int happiness)
        {
            var outputWriter = Substitute.For<IOutputWriter>();
            var listener = new Listener(outputWriter);
            Assert.IsFalse(listener.CheckIfAllive(new TamagotchiStatus(energy, hunger, happiness)));
        }
        [TestCase(0,10, 0)]
        [TestCase(0, 9, 0)]
        [TestCase(0, 3, 0)]
        public void Check_If_Can_Eat_When_Allowed(int energy, int hunger, int happiness)
        {
            var outputWriter = Substitute.For<IOutputWriter>();
            var listener = new Listener(outputWriter);
            Assert.IsTrue(listener.CheckIfCanEat(new TamagotchiStatus(energy, hunger, happiness)));
        }
        [TestCase(2, 0, 2)]
        public void Check_If_Can_Eat_When_Not_Allowed(int energy, int hunger, int happiness)
        {
            var outputWriter = Substitute.For<IOutputWriter>();
            var listener = new Listener(outputWriter);
            Assert.IsFalse(listener.CheckIfCanEat(new TamagotchiStatus(energy, hunger, happiness)));
        }
        //reszta testow wygladalaby tak samo, tylko metdoy by się zmieniały
    }
}

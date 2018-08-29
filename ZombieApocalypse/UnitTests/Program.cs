using ZombieApocalypse;
using FluentAssertions;
using NUnit.Framework;

namespace ConsoleApp2.Unit_Tests
{
    [TestFixture]
    class TestZombieApocalypse
    {
        [Test]
        public void test1()
        {
            var x = new Game();
            x.intervene();
            //Program.intervene();
        }
    }
}
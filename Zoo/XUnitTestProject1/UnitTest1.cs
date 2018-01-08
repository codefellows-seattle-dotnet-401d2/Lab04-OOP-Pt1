using System;
using Xunit;
using Zoo.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        DireWolf fluffy = new DireWolf();
        Snake dangernoodle = new Snake();
        Chameleon larry = new Chameleon();

        [Fact]
        public void FluffyLegs()
        {
            Assert.Equal(4, fluffy.Legs);
        }

        [Fact]
        public void LarryLegs()
        {
            Assert.Equal(4, larry.Legs);
        }

        [Fact]
        public void DangerNoodleLegs()
        {
            Assert.Equal(0, dangernoodle.Legs);
        }
    }
}

using Xunit;
using static Zoo;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AnimalTest()
        {
            Assert.True(Animal.Alive() == true);
        }
    }
}

using System;
using Xunit;
using Zoo;
using Zoo.Classes;


namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void CheckZebraClass()
        {
            Assert.Equal("Zebras live in Africa!", Zebra.Location());
        }

       [Fact]
        public void CheckLionLocation()
        {
            Assert.Equal("Lions live in Africa south of the Sahara Desert", Lion.Location());
        }

       [Fact]
        public void CheckWestAfricanInheritance()
        {
            Assert.Equal("Lions live in Africa south of the Sahara Desert", WestAfrican.CheckLion());
        }

        [Fact]
        public void CheckCapeZebraInheritance()
        {
            Assert.Equal("Zebras live in Africa!", Cape.CheckZebra());
        }
    }
}

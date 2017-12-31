using System;
using Xunit;
using Zoo;

namespace XUnitTestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void TestHominidaeInheritsMammalia()
        {
            Hominidae human = new Hominidae();
            Assert.Equal("Mammals nurse their young with milk.", human.Nurse());
        }

        [Fact]
        public void TestHominidaeInheritsPrimates()
        {
            Hominidae human = new Hominidae();
            Assert.Equal("Opposable thumbs allow primates to have a strong hold on things.", human.UsePowerGrip());
        }

        [Fact]
        public void TestHominidaeAbstraction()
        {
            Hominidae human = new Hominidae();
            Assert.Equal("Hominidae can use speech or sign language to communicate.", human.Communicate());
        }

        [Fact]
        public void TestCebidaeInheritsMammalia()
        {
            Cebidae capuchin = new Cebidae();
            Assert.Equal("Mammals nurse their young with milk.", capuchin.Nurse());
        }

        [Fact]
        public void TestCebidaeInheritsPrimates()
        {
            Cebidae capuchin = new Cebidae();
            Assert.Equal("Opposable thumbs allow primates to have a strong hold on things.", capuchin.UsePowerGrip());
        }

        [Fact]
        public void TestCebidaeAbstraction()
        {
            Cebidae capuchin = new Cebidae();
            Assert.Equal("Cebidae communicate with sounds and gestures.", capuchin.Communicate());
        }

        [Fact]
        public void TestCanidaeInheritsMammalia()
        {
            Canidae dog = new Canidae();
            Assert.Equal("Mammals nurse their young with milk.", dog.Nurse());
        }

        [Fact]
        public void TestCanidaeInheritsCarnivora()
        {
            Canidae dog = new Canidae();
            Assert.Equal("Carnivora hunts with teeth and claws.", dog.Hunt());
        }

        [Fact]
        public void TestCanidaeAbstraction()
        {
            Canidae dog = new Canidae();
            Assert.Equal("Dog-like howl or bark.", dog.Communicate());
        }

        [Fact]
        public void TestFelidaeInheritsMammalia()
        {
            Felidae cat = new Felidae();
            Assert.Equal("Mammals nurse their young with milk.", cat.Nurse());
        }

        [Fact]
        public void TestFelidaeInheritsCarnivora()
        {
            Felidae cat = new Felidae();
            Assert.Equal("Carnivora hunts with teeth and claws.", cat.Hunt());
        }

        [Fact]
        public void TestFelidaeAbstraction()
        {
            Felidae cat = new Felidae();
            Assert.Equal("Cat-like roar or meow", cat.Communicate());
        }
    }
}

sing OHCE_B3;
using OHCE_B3.Langues;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class OhceTest
    {
        [Fact]
        public void miroirTest()
        {
            Ohce ohce = new Ohce();

            var sortie = ohce.palyndrome("yolo");

            Assert.Equal("oloy", sortie);
        }

        [Fact]
        public void palyndromeTest()
        {
            Ohce ohce = new Ohce();

            var sortie = ohce.palyndrome("kayak");
            string palyndrome = "kayak";

            Assert.Contains(palyndrome + " Bien dit !", sortie);
        }

    }
}
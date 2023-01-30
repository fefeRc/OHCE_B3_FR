using OHCE_B3;
using OHCE_B3.Langues;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class LangueTest
    {
        [Theory]
        [InlineData(Expressions.Français.Bonjour)]
        public void testFrancais(string salutationAttendue)
        {
            ILangue francais = new Francais();

            var bonjour = francais.Bonjour;

            Assert.Equal(salutationAttendue, bonjour);

        }

        [Theory]
        [InlineData(Expressions.English.Bonjour)]
        public void testAnglais(string salutationAttendue)
        {
            ILangue anglais = new Anglais();

            var hello = anglais.Bonjour;

            Assert.Equal(salutationAttendue, hello);

        }

    }
}
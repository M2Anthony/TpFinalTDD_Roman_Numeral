using TpFinalTDD.Core;

namespace TpFinalTDD.TestsNUnit
{
    public class ConvertisseurChiffresRomainsTests
    {
        private ConvertisseurChiffresRomains _convertisseur;

        [SetUp]
        public void Setup()
        {
            _convertisseur = new ConvertisseurChiffresRomains();
        }

        [Test]
        public void ConversionVersEntier_Quand_chiffresRomains_EstVide_Alors_ArgumentException()
        {            
            // Assert & Act

            Assert.Throws<ArgumentException>( () => _convertisseur.ConversionVersEntier("") );

        }
        
    }
}
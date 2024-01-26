using TpFinalTDD.Core;

namespace TpFinalTDD.TestsNUnit
{
    public class ConvertisseurChiffresRomainsTests
    {
        private ConvertisseurChiffresRomains _convertisseur;

        [SetUp]
        public void Setup()
        {
            // Arrange 

            _convertisseur = new ConvertisseurChiffresRomains();
        }

        [Test]
        public void ConversionVersEntier_Quand_chiffresRomains_EstVide_Alors_ArgumentException()
        {            
            // Assert & Act

            Assert.Throws<ArgumentException>( () => _convertisseur.ConversionVersEntier("") );

        }

        [Test]
        [TestCase("j")]
        [TestCase("p")]
        [TestCase("h")]
        [TestCase("hI")]
        [TestCase("a")]
        [TestCase("XVaI")]
        public void ConverstionVersEntier_Quand_chiffreRomains_ContientAutreChoseQuauMoinsUneDesLettres_I_V_X_L_C_D_M_Alors_ArgumentException(string chiffresRomains)
        {
            // Assert & Act

            Assert.Throws<ArgumentException>(() => _convertisseur.ConversionVersEntier(chiffresRomains));
        }

        [Test]
        [TestCase("i")]
        [TestCase("v")]
        [TestCase("x")]
        [TestCase("XiV")]
        [TestCase("XIv")]
        [TestCase("mDC")]
        public void ConversionVersEntier_Quand_chiffresRomains_ContientUniquement_CaractereAutorise_Mais_EstMinuscule_Alors_ArgumentException(string chiffresRomains)
        {
            // Assert & Act

            Assert.Throws<ArgumentException>(() => _convertisseur.ConversionVersEntier(chiffresRomains));

        }

        [Test]
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]        
        public void ConversionVersEntier_Quand_chiffreRomainEstValide_Alors_NombreEntierCorrespondant(string chiffreRomain, int resultatAttendu)
        {
            // Assert & Act

            Assert.That(resultatAttendu, Is.EqualTo(_convertisseur.ConversionVersEntier(chiffreRomain)));
        }

    }
}
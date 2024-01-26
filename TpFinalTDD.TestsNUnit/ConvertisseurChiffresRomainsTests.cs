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

    }
}
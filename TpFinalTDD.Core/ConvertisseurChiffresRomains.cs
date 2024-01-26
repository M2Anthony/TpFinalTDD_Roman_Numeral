namespace TpFinalTDD.Core
{
    public class ConvertisseurChiffresRomains
    {
        

        /// <summary>
        /// Méthode permettant de convertir des chiffres romains en nombre entier
        /// </summary>
        /// <param name="chiffresRomains"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int ConversionVersEntier(string chiffresRomains)
        {
            if (string.IsNullOrEmpty(chiffresRomains))
            {
                throw new ArgumentException("Votre chaine ne peut pas être vide");
            }
            foreach (char caractere in chiffresRomains)
            {
                if (!Enum.GetNames(typeof(EquivalenceChiffreRomainsVersEntier)).Cast<string>().ToList().Contains(caractere.ToString()))
                {
                    throw new ArgumentException($"Le caractère {caractere} n'est pas autorisé");
                }
            }

            if (chiffresRomains.Length == 1)
            {
               return (int) Enum.Parse(typeof(EquivalenceChiffreRomainsVersEntier), chiffresRomains);
            }

            throw new NotImplementedException();

        }

        /// <summary>
        /// Méthode permettant de convertir un nombre entier en chiffres romains
        /// </summary>
        /// <param name="entier"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ConversionDepuisEntier(int entier)
        {
            throw new NotImplementedException();
        }
    }

    internal enum EquivalenceChiffreRomainsVersEntier
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
}

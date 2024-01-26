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
                if (!"IVXLCDM".Contains(caractere))
                {
                    throw new ArgumentException($"Le caractère {caractere} n'est pas autorisé");
                }
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
}

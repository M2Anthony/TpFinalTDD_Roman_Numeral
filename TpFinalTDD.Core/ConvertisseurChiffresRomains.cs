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
            List<char> listeChiffresRomains = new List<char>();

            foreach (var lettre in chiffresRomains)
            {
                listeChiffresRomains.Add(lettre);
            }

            int somme = 0;

            while(listeChiffresRomains.Count > 0)
            {
                char lettreActuelle = listeChiffresRomains[0];
                char? lettreSuivante = listeChiffresRomains.Count > 1 ? listeChiffresRomains[1] : null;

                if (lettreSuivante == null)
                {
                    somme += (int)Enum.Parse(typeof(EquivalenceChiffreRomainsVersEntier), lettreActuelle.ToString());
                    break;
                }
                else
                {
                    int valeurLettreActuelle = (int)Enum.Parse(typeof(EquivalenceChiffreRomainsVersEntier), lettreActuelle.ToString());
                    int valeurLettreSuivante = (int)Enum.Parse(typeof(EquivalenceChiffreRomainsVersEntier), lettreSuivante.ToString());

                    if (valeurLettreSuivante > valeurLettreActuelle)
                        somme += valeurLettreSuivante - valeurLettreActuelle;
                    else if (valeurLettreSuivante <= valeurLettreActuelle)
                        somme += valeurLettreSuivante + valeurLettreActuelle;

                    listeChiffresRomains.RemoveAt(0);
                    listeChiffresRomains.RemoveAt(0);
                }
            }

            return somme;

            //for (int i = 0; i < listeChiffresRomains.Count; i++)
            //{
            //    char lettreActuelle;
            //    char? lettrePrecedente = null;
            //    char? lettreSuivante = null;

            //    lettreActuelle = chiffresRomains[i];

            //    if (i > 0)
            //    {
            //        lettrePrecedente = chiffresRomains[i - 1];
            //    }
            //    if (i < chiffresRomains.Length - 1)
            //    {
            //        lettreSuivante = chiffresRomains[i + 1];
            //    }



            //}

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

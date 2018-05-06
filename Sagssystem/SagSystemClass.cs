using System;
using System.Collections.Generic;

namespace Sagssystem
{
    [Serializable]      // required for serialization.
    class SagSystemClass
    {
        public List<Projekt> projekter;
        public List<Sag> sager;
        public List<Obs> obser;

        public SagSystemClass()
        {
            // Initialiserer sagsystem Class
        }

        public List<Projekt> FindProjekterPrRegistreretAF(String opretter)
        {
            var resultat = new List<Projekt>();

            foreach (Projekt projekt in projekter)
            {
                if (projekt.RegistreretAf == opretter)
                {
                    resultat.Add(projekt);
                }
            }

            return resultat;
        }

        public List<Sag> FindSagerPrRegistreretAF(String opretter)
        {
            var resultat = new List<Sag>();

            foreach (Sag sag in sager)
            {
                if (sag.RegistreretAf == opretter)
                {
                    resultat.Add(sag);
                }
            }

            return resultat;
        }

        public List<Obs> FindObserPrRegistreretAF(String opretter)
        {
            var resultat = new List<Obs>();

            foreach (Obs obs in obser)
            {
                if (obs.RegistreretAf == opretter)
                {
                    resultat.Add(obs);
                }
            }

            return resultat;
        }

        public List<Sag> FindSagerUnderProjekt(int projektID)
        {
            var resultat = new List<Sag>();

            foreach (Sag sag in sager)
            {
                if (sag.TilhørerProjekt == projektID)
                {
                    resultat.Add(sag);
                }
            }

            return resultat;
        }

        public List<Obs> FindObserUnderSag(int sagID)
        {
            var resultat = new List<Obs>();

            foreach (Obs obs in obser)
            {
                if (obs.TilhørerSag == sagID)
                {
                    resultat.Add(obs);
                }
            }

            return resultat;
        }
    }
}

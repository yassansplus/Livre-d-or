using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LivreDOr
{
    class Livre
    {
        private ArrayList mesCritiques= new ArrayList();
        private DataBaseTask myActionOnDB = new DataBaseTask();
        public Livre()
        {
            this.ajouterCritique();
        }

        public void ajouterCritique()
        {
            bool stayIn = true;
            do
            {
                Console.Write("Saisissez votre nom:");
                string name = Console.ReadLine();
                Console.WriteLine("Saisissez votre message: ");
                string message = Console.ReadLine();
                if (message != "quit" || name != "quit")
                {
                    Critique maCritique = new Critique();
                    maCritique.Message = message;
                    maCritique.Name= name;

                    this.mesCritiques.Add(maCritique);
                    this.myActionOnDB.insererCritique(maCritique);
                    
                    this.voirMesCritiques(this.myActionOnDB.findAllCritiques());
                }
                else
                {
                    stayIn = false;
                }


            } while (stayIn);
        }
        public void voirMesCritiques(ArrayList mesCritiques)
        {
            Console.Clear();

            foreach (Critique maCritique in mesCritiques)
            {
                Console.WriteLine(maCritique.Name + " | " + maCritique.Message);


            }
        }

    }
}

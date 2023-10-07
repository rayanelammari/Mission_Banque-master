using LibBqCpt;

namespace testUnCptBq
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuperieur()
        {
            // Arranger 

            bool attendu = false;
            Compte cpt1 = new Compte(12345, "Rayane", 15, -500);
            Compte cpt2 = new Compte(54321, "Lammari", 20, -2000);

            //Agir
            bool actuel = cpt1.SuperieurCompte(cpt2);


            //Auditer
            Assert.AreEqual(attendu, actuel, "Inférieur");

        }
        [TestMethod]
        public void TestDebiter()
        {
            // Arranger 
            bool attendu = false;
            int decouvertAutorise = -500;
            int solde = 1500;
            int montant=3000;

            Compte cpt1 = new Compte(12345, "Rayane", solde, decouvertAutorise);

            //Agir
            bool actuel = cpt1.DebiterCompte(montant);

            //Auditer
            Assert.AreEqual(attendu, actuel, "Decouvert max dépassé");

        }
        [TestMethod]
        public void TestTransferer()
        {
            // Arranger 
            bool attendu = true;
            int decouvertAutorise = -500;
            int solde = 1500;
            int montant = 50;
            int decouvertAutorise2 = -2000;
            int solde2 = 1000;


            Compte cpt1 = new Compte(12345, "Rayane", solde, decouvertAutorise);
            Compte cpt2 = new Compte(54321, "Lammari", solde2, decouvertAutorise2);


            //Agir
            bool actuel = cpt1.Transferer(montant,cpt2);

            //Auditer
            Assert.AreEqual(attendu, actuel, "Transfert réusi");

        }

    }
}
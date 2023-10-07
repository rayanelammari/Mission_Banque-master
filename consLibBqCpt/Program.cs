// See https://aka.ms/new-console-template for more information
using LibBqCpt;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;


//Test  : 
Compte c = new Compte(54321,"titi",2000,-1000);
Compte c1 = new Compte(12345, "toto", 1000, -500);
Console.WriteLine(c.ToString());
Console.WriteLine(c1.ToString());

Console.WriteLine("-----------------Créditer/Débiter------------------");
//test Créditer/Débiter :
c1.CrediterCompte(2000);
c.DebiterCompte(2000);
Console.WriteLine(c.ToString());
Console.WriteLine(c1.ToString());

Console.WriteLine("----------------- Transferer------------------");
//Test Transferer :
c1.Transferer(3300,c);
Console.WriteLine(c1.ToString());
Console.WriteLine(c.ToString());

Console.WriteLine("---------------Supérieur --------------------");
//Supérieur
if(c1.SuperieurCompte(c))
{
    Console.WriteLine("Supérieur");
}else
{
    Console.WriteLine("Inférieur");
}
Console.WriteLine("-----------------Ajouter Compte ------------------");
//Supérieur
Banque b = new Banque();
b.AjouterCompte(45854, "Rayane", 3000, -500);
Console.WriteLine(b.ToString());

Console.WriteLine("-------------Retourne Compte----------------------");
//RendCompte
b.Ajouter(c1);
b.Ajouter(c);
Console.WriteLine(b.RendCompte(12345).ToString());

Console.WriteLine("-------------Ajouter Type----------------------");
b.AjouterType("pre", "Prélèvement", "-");
b.AjouterType("ch", "chèque débité", "-") ;
b.AjouterType("pre", "prélèvement", "-");
b.AjouterType("dab", "retrait en distributeur", "-");
b.AjouterType("ret", "retrait guichet ", "-");
b.AjouterType("vir", "virement sur compte", "+");
b.AjouterType("dch", "chèque déposé", "+");
b.AjouterType("des", "dépôt d’espèce", "+");



Console.WriteLine("-------------Rend Type----------------------");
Console.WriteLine(b.getType("ch").ToString());

Console.WriteLine("-------------Mouvement----------------------");
b.AjouterCompte(45657, "titi", 2000, -1000);
b.RendCompte(45657).AjouterMouvement(new DateTime(2012, 09, 11),200,b.getType("vir"));
Compte c2;
c2 = b.RendCompte(45657);
c2.AjouterMouvement(new DateTime(2017, 09, 11), 200, b.getType("vir"));
c2.AjouterMouvement(new DateTime(2017, 09, 12), 500, b.getType("ret"));
c2.AjouterMouvement(new DateTime(2017, 09, 13),500, b.getType("vir"));

Console.WriteLine(c2.ToString());
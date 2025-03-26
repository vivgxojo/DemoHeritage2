using DemoHeritage2;

IDocument document1; //Déclarer des variable de type interface
IDocument document2;
Livre livre1;
Jeu jeu1;

document1 = new Livre(){    //Instancier avec une classe
    Titre = "Harry Potter", //Utilisation du constructeur vide
    NombreDisponibles = 1,
    NombreExemplaires = 1
};    
document2 = new Jeu() {     
    Titre = "Pokemon",      
    Cout = 2,
    NombreExemplaires = 4,
    NombreDisponibles = 3
};
livre1 = new Livre() ;
jeu1 = new Jeu();

List<IDocument> emprunts = new List<IDocument>();
Console.WriteLine(document2.Titre + " " + document2.NombreDisponibles);
if (document2.Retirer())
{
    emprunts.Add(document2) ;
    Console.WriteLine("Le document " + emprunts[0].Titre + " doit être retourné dans 1 semaine");
}
Console.WriteLine(document2.Titre + " " + document2.NombreDisponibles);
if (document1.Retirer()) 
{  
    emprunts.Add(document1);
    Console.WriteLine("Le document " + emprunts[1].Titre + " doit être retourné dans 1 semaine");
}
emprunts.Add(livre1);   
emprunts.Add(jeu1);
foreach (IDocument document in emprunts)
{
    Console.WriteLine(document);
}


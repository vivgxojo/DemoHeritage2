using DemoHeritage2;

IEmpruntable document1; //Déclarer des variable de type interface
IEmpruntable document2; 
_Document document3;    //Déclarer des variable de type abstrait
Livre livre1;
Jeu jeu1;
Film film1 = new Film() {
    Titre = "Jaws",
    NombreDisponibles = 3,
    NombreExemplaires = 3,
    Cout = 1
};

document3 = new Film(){      //Instancer avec une classe concrète
    Titre = "Titanic",
    NombreDisponibles = 3,
    NombreExemplaires = 3,
    Cout = 1
};

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

List<IEmpruntable> emprunts = new List<IEmpruntable>();
                    //Cast : polymorphisme
Console.WriteLine(((Jeu)document2).Titre + " " + document2.NombreDisponibles);
if (document2.Retirer())
{
    emprunts.Add(document2) ;
    Console.WriteLine("Le document " + ((_Document)emprunts[0]).Titre + " doit être retourné dans 1 semaine");
}
Console.WriteLine();
Console.WriteLine(((_Document)document2).Titre + " " + document2.NombreDisponibles);
if (document1.Retirer()) 
{  
    emprunts.Add(document1); 
    Console.WriteLine("Le document " + ((_Document)emprunts[1]).Titre + " doit être retourné dans 1 semaine");
}
Console.WriteLine();
//if (((Film)document3).Retirer()) // new : Retirer() dans la classe enfant
if (document3.Retirer()) // new : Retirer() dans la classe parent
{
    emprunts.Add(document3);
    Console.WriteLine("Le document " + ((_Document)emprunts[2]).Titre + " doit être retourné dans 1 semaine");
}
Console.WriteLine();
//if (((_Document)film1).Retirer()) // new : Retirer() dans la classe parent
if (film1.Retirer()) // new : Retirer() dans la classe enfant
{
    emprunts.Add(film1);
    Console.WriteLine("Le document " + ((_Document)emprunts[3]).Titre + " doit être retourné dans 1 semaine");
}
Console.WriteLine();
document1.Retourner();
emprunts.Remove(document1);
emprunts.Add(livre1);   
emprunts.Add(jeu1);
foreach (_Document document in emprunts)
{
    Console.WriteLine(document);
}


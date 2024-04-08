using System; 

class URI {

    static void Main(string[] args) { 

        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        string name3 = Console.ReadLine();
        if (name1 == "vertebrado" && name2 == "ave" && name3 == "carnivoro"){
            Console.WriteLine("aguia");
        }
        else if (name1 == "vertebrado" && name2 == "ave" && name3 == "onivoro"){
            Console.WriteLine("pomba");
        }
        else if (name1 == "vertebrado" && name2 == "mamifero" && name3 == "onivoro"){
            Console.WriteLine("homem");
        }
        else if (name1 == "vertebrado" && name2 == "mamifero" && name3 == "herbivoro"){
            Console.WriteLine("vaca");
        }
        else if (name1 == "invertebrado" && name2 == "inseto" && name3 == "hematofago"){
            Console.WriteLine("pulga");
        }
        else if (name1 == "invertebrado" && name2 == "inseto" && name3 == "herbivoro"){
            Console.WriteLine("lagarta");
        }
        else if (name1 == "invertebrado" && name2 == "anelideo" && name3 == "hematofago"){
            Console.WriteLine("sanguessuga");
        }
        else if (name1 == "invertebrado" && name2 == "anelideo" && name3 == "onivoro"){
            Console.WriteLine("minhoca");
        }
    }
}

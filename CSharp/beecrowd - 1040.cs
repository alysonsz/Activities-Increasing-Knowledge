using System; 

class URI {

    static void Main(string[] args) { 

        string[] notes = Console.ReadLine().Split(' ');
        double note1 = double.Parse(notes[0]);
        double note2 = double.Parse(notes[1]);
        double note3 = double.Parse(notes[2]);
        double note4 = double.Parse(notes[3]);
        double final_media = 0;
        
        double exam = 0;
        double media = (note1*2 + note2*3 + note3*4 + note4)/10;
        media = Math.Round(media, 1, MidpointRounding.ToEven);
        Console.WriteLine("Media: {0:0.0}", media);
        if(media >= 7){
            Console.WriteLine("Aluno aprovado.");
        }
        else if(media < 5){
            Console.WriteLine("Aluno reprovado.");
        }
        else if(media >= 5 && media < 7){
            Console.WriteLine("Aluno em exame.");
            exam = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0:0.0}", exam);
            final_media = (media + exam)/2;
            final_media = Math.Round(final_media, 1, MidpointRounding.ToEven);
            if(final_media >= 5){
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: {0:0.0}", final_media);
        }   
            if(final_media < 5 && final_media > 0){
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: {0:0.0}", final_media);
        }
        }
    }
}

using System; 

class URI {

    static void Main(string[] args) { 

        string[] values = Console.ReadLine().Split(' ');
        int start = int.Parse(values[0]);
        int end = int.Parse(values[1]);
        int time;
        if (start >= end){
            time = 24 + end;
            time = time - start;
        }
        else{
            time = start - end;
            time = Math.Abs(time);
        }
        Console.WriteLine("O JOGO DUROU {0} HORA(S)", time);
    }

}

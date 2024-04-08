using System; 

class URI {

    static void Main(string[] args) { 
        int count = 0;
        double media = 0;
        for (int i = 0; i < 6; i++){
            double numbers = double.Parse(Console.ReadLine());
            if (numbers * -1 < 0){
                count = count + 1;
                media = media + numbers;
            }
        }
        media = media/count;
        Console.WriteLine("{0} valores positivos\n{1:0.0}", count, media);

    }

}

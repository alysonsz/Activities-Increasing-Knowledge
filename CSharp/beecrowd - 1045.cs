using System; 

class URI {

    static void Main(string[] args) { 

        string[] values = Console.ReadLine().Split();
        double sideA = double.Parse(values[0]);
        double sideB = double.Parse(values[1]);
        double sideC = double.Parse(values[2]);
        double aux = 0;
        if (sideA < sideB){
            aux = sideB;
            sideB = sideA;
            sideA = aux;
        }
        if (sideA < sideC){
            aux = sideC;
            sideC = sideA;
            sideA = aux;
        }
        if(sideB < sideC){
            aux = sideC;
            sideC = sideB;
            sideB = aux;
        }
        if (sideA >= (sideB + sideC)){
            aux = 1;
            goto final;
        }
        if ((sideA*sideA) == ((sideB*sideB) + (sideC*sideC))){
            Console.WriteLine("TRIANGULO RETANGULO");
            aux = 0;
        }
        if ((sideA*sideA) > ((sideB*sideB) + (sideC*sideC))){
            Console.WriteLine("TRIANGULO OBTUSANGULO");
            aux = 0;
        }
        if ((sideA*sideA) < ((sideB*sideB) + (sideC*sideC))){
            Console.WriteLine("TRIANGULO ACUTANGULO");
            aux = 0;
        }
        if ((sideA == sideB) && (sideA == sideC)){
            Console.WriteLine("TRIANGULO EQUILATERO");
            aux = 0;
        }
        if (((sideA == sideB) && sideA != sideC) || ((sideB == sideC) && sideB != sideA) || ((sideA == sideC) && sideA != sideB)){
            Console.WriteLine("TRIANGULO ISOSCELES");
            aux = 0;
        }
        final:
        if (aux == 1){
            Console.WriteLine("NAO FORMA TRIANGULO");
            }
    }
}

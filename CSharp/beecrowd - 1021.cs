using System; 

class Teste {

    static void Main(string[] args) { 
        int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0 , nota5 = 0, nota2 = 0, moeda1 = 0, moeda50 = 0, moeda25 = 0, moeda10 = 0, moeda05 = 0, moeda01 = 0;
        double dinheiro = double.Parse(Console.ReadLine());
        while(true){
            if (dinheiro <= 0){
                break;
            }
            if ((dinheiro/100) >= 1){
                dinheiro = dinheiro - 100;
                nota100 = nota100 + 1;
            } 
            else if ((dinheiro/50) >= 1){
                dinheiro = dinheiro - 50;
                nota50 = nota50 + 1;
            } 
            else if ((dinheiro/20) >= 1){
                dinheiro = dinheiro - 20;
                nota20 = nota20 + 1;
            } 
            else if ((dinheiro/10) >= 1){
                dinheiro = dinheiro - 10;
                nota10 = nota10 + 1;
            } 
            else if ((dinheiro/5) >= 1){
                dinheiro = dinheiro - 5;
                nota5 = nota5 + 1;
            } 
            else if ((dinheiro/2) >= 1){
                dinheiro = dinheiro - 2;
                nota2 = nota2 + 1;
            } 
            else if (dinheiro >= 1){
                dinheiro = dinheiro - 1;
                moeda1 = moeda1 + 1;
            }

            else if ((dinheiro/0.5) >= 1){
                dinheiro = dinheiro - 0.50;
                dinheiro = Math.Round(dinheiro, 2);
                moeda50 = moeda50 + 1;
            } 
            else if ((dinheiro/0.25) >= 1){
                dinheiro = dinheiro - 0.25;
                dinheiro = Math.Round(dinheiro, 2);
                moeda25 = moeda25 + 1;
            } 
            else if ((dinheiro/0.1) >= 1){
                dinheiro = dinheiro - 0.1;
                dinheiro = Math.Round(dinheiro, 2);
                moeda10 = moeda10 + 1;
            } 
            else if ((dinheiro/0.05) >= 1){
                dinheiro = dinheiro - 0.05;
                dinheiro = Math.Round(dinheiro, 2);
                moeda05 = moeda05 + 1;
            } 
            else if ((dinheiro/0.01) >= 1){
                dinheiro = dinheiro - 0.01;
                dinheiro = Math.Round(dinheiro, 2);
                moeda01 = moeda01 + 1;
            } 
        }
        Console.WriteLine("NOTAS:\n{0} nota(s) de R$ 100.00\n{1} nota(s) de R$ 50.00\n{2} nota(s) de R$ 20.00\n{3} nota(s) de R$ 10.00\n{4} nota(s) de R$ 5.00\n{5} nota(s) de R$ 2.00\nMOEDAS:\n{6} moeda(s) de R$ 1.00\n{7} moeda(s) de R$ 0.50\n{8} moeda(s) de R$ 0.25\n{9} moeda(s) de R$ 0.10\n{10} moeda(s) de R$ 0.05\n{11} moeda(s) de R$ 0.01", nota100, nota50, nota20, nota10, nota5, nota2, moeda1, moeda50, moeda25, moeda10, moeda05, moeda01);
    }
}

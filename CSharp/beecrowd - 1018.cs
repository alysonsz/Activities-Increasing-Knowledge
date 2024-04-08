using System; 

class URI {

    static void Main(string[] args) { 
        int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0 , nota5 = 0, nota2 = 0, nota1 = 0;
        int dinheiro;
        int dinheiroInicial;
        dinheiro = int.Parse(Console.ReadLine());
        dinheiroInicial = dinheiro;
        while(dinheiro != 0){
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
            else if (dinheiro == 1){
                dinheiro = dinheiro - 1;
                nota1 = nota1 + 1;
            }
        }
        Console.WriteLine("{0}\n{1} nota(s) de R$ 100,00\n{2} nota(s) de R$ 50,00\n{3} nota(s) de R$ 20,00\n{4} nota(s) de R$ 10,00\n{5} nota(s) de R$ 5,00\n{6} nota(s) de R$ 2,00\n{7} nota(s) de R$ 1,00", dinheiroInicial, nota100, nota50, nota20, nota10, nota5, nota2, nota1);
    }
}

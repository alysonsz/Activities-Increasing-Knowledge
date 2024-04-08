using System; 

class URI {

    static void Main(string[] args) { 
        
        double salary = double.Parse(Console.ReadLine());
        double reajust = 0;
        int percent = 0;
        double newsalary = 0;

        if (salary >= 0 && salary <= 400){
            reajust = (salary * 0.015)*10;
            percent = 15;
        }
        else if (salary >= 400.01 && salary<= 800){
            reajust = (salary * 0.012)*10;
            percent = 12;
        }
        else if (salary >= 800.01 && salary <= 1200){
            reajust = (salary * 0.010)*10;
            percent = 10;
        }
        else if (salary >= 1200.01 && salary <= 2000){
            reajust = (salary * 0.007)*10;
            percent = 7;
        }
        else if (salary > 2000){
            reajust = (salary * 0.004)*10;
            percent = 4;
        }
        newsalary = salary + reajust;
        Console.WriteLine("Novo salario: {0:0.00}\nReajuste ganho: {1:0.00}\nEm percentual: {2} %", newsalary, reajust, percent);

    }

}

using System.Runtime.ConstrainedExecution;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter your salary before tax ");

        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);

        Console.WriteLine("Enter the value of tax ");

        bool taxIsInt = double.TryParse(Console.ReadLine(), out double tax);

        if (salaryIsInt){
            if (taxIsInt)
            {
                int salaryNet = Impots(salary,tax);
                Console.WriteLine("Salaire Net:  " + salaryNet);
                Console.ReadLine();

            }

        }
        else
        {
            Console.WriteLine("Your salary or tax are'nt integer");
        }



    }
    static int Impots(int a, double b)
    {
        int salary = a;
        
        double taxes = b / 100;

        int salaryTemp= (int)(a * taxes);


        if (salary > 50000)
        {
            Console.WriteLine("You should to give many money to downgarde your tax !");
            salary = salary - salaryTemp;
            return salary;
        }
        if (salary / 12 > 1500)
        {
            Console.WriteLine("No probleme, it's OK for a work-study !");
            salary = salary - salaryTemp;
            return salary;
        }
        if (salary >= 40000 & salary <= 30000){
            Console.WriteLine("You should to do a bac+5 at Cesi ;)");
            salary = salary - salaryTemp;
            return salary;
        }


        salary = salary - salaryTemp;
        return salary;

    }
}
using System.Runtime.ConstrainedExecution;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter your salary before tax ");

        int salary = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of tax ");

        double taxe = int.Parse(Console.ReadLine());

        int salaryNet = Impots(salary,taxe);

        Console.WriteLine("Salaire Net:  " + salaryNet);
        Console.ReadLine();

    }
    static int Impots(int a, double b)
    {
        int salary = a;

        double taxes = b / 100;

        int salaryTemp= (int)(a * taxes);

        salary = salary - salaryTemp;

        return salary;

    }
}
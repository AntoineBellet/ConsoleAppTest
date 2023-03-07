using System.Runtime.ConstrainedExecution;

class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Enter your salary before tax ");

        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);

        Console.WriteLine("Enter the value of tax ");

        bool taxIsInt = double.TryParse(Console.ReadLine(), out double tax);

        if (salaryIsInt)
        {
            if (taxIsInt)
            {
                int salaryNet = Impots(salary, tax);
                Console.WriteLine("Salaire Net annuel:  " + salaryNet);
                SalaryPerMonth(salaryNet);
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

        int salaryTemp = (int)(a * taxes);

        switch (salary)
        {
            case >= 50000:
                Console.WriteLine("You should to give many money to downgarde your tax !");
                salary = salary - salaryTemp;
                break;
            case < 1500 * 12:
                Console.WriteLine("No probleme, it's OK for a work-study !");
                salary = salary - salaryTemp;
                break;
            case int x when x <= 40000 && x >= 30000:
                Console.WriteLine("You should to do a bac+5 at Cesi ;)");
                salary = salary - salaryTemp;
                break;
        }

        salary = salary - salaryTemp;
        return salary;
    }

    static void SalaryPerMonth(int salary)
    {
        double salaryNetPerMonth = salary / 12;

        string[] monthsCalendar = new string[] { "Janaruy", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December", "Prime"};

        try
        {
            Console.WriteLine("Entrer le pourcentage de prime que vous souhaiter");
            int pourcentagePrime = int.Parse(Console.ReadLine());
            double prime = salary * pourcentagePrime / 100;
            for (int i = 0; i < monthsCalendar.Length; i++)
            {
                if (monthsCalendar[i] == "August")
                {
                    Console.WriteLine(monthsCalendar[i] + " : Vacances");
                    continue;
                }
                else if (monthsCalendar[i] == "Prime")
                {
                    Console.WriteLine(monthsCalendar[i] + " de fin d'année : " + prime + "€");
                }
                else
                {
                    Console.WriteLine(monthsCalendar[i] + " : " + salaryNetPerMonth + "€");
                }
            }

        }
        catch (FormatException e)
        {
            Console.WriteLine("Le pourcentage de la prime doit être un double");
            Environment.Exit(1);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Le pourcentage de la prime ne peut pas être égal à 0");
            Environment.Exit(1);
        }
    }

}


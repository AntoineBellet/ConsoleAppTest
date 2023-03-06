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

        if (salaryIsInt){
            if (taxIsInt)
            {
                int salaryNet = Impots(salary,tax);
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

        int salaryTemp= (int)(a * taxes);

        switch (salary)
        {
            case >= 50000:
                Console.WriteLine("You should to give many money to downgarde your tax !");
                salary = salary - salaryTemp;
                break;
            case  < 1500 * 12:
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
        int salaryNetPerMonth = salary / 12;

        int prime = (int)(salary * 0.1);

        string[] monthCalendar = new string[] { "Janaruy", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December", "Prime"};


        for (int i = 0; i < monthCalendar.Length; i++)
            {
                if (monthCalendar[i] == "August")
                {
                    Console.WriteLine(monthCalendar[i] + " : Vacances");
                }
                else if (monthCalendar[i] == "Prime")
                {
                    Console.WriteLine(monthCalendar[i] + " de fin d'année : " + prime + "€");
                }
                else
                {
                    Console.WriteLine(monthCalendar[i] + " : " + salaryNetPerMonth + "€");
                }
            }
        }

    }

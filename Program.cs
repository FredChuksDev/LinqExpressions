using System.Linq;
namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> intNum = new List <int>{19,23,53,66,5,500,10,45, 33,56 };
            //List<int> intNewNum = intNum.Where(num => num >= 50).ToList();
            //List<int> evenNum = intNum.Where(evnum => evnum%2 ==0).ToList();
            //List<int> oddNum = intNum.Where(oddnum => oddnum%2 != 0).ToList();
            //var average = intNum.Average();
            //Console.WriteLine(average);

            //int sum = intNum.Where(evnum => evnum % 2 == 0).ToList().Sum();
            //Console.WriteLine(sum);
            //foreach(int num in evenNum)
            //{
            //    Console.WriteLine(num);
            //}


            //List<Employee> Employees = new List<Employee> 
            //{ 
            //    new Employee{ Name = "Mark", Salary = 200 },
            //    new Employee{ Name = "Jerry", Salary = 300},
            //    new Employee{ Name = "Jude", Salary = 150},
            //    new Employee{ Name = "George", Salary = 20},
            //    new Employee{ Name = "Esther", Salary = 300 },
            //    new Employee{ Name = "Simi", Salary = 340},
            //    new Employee{ Name = "Jenny", Salary = 350},
            //    new Employee{ Name = "Victoria", Salary = 209}
            //};

            //List<Employee> EmployeeWithBonus = Employees.Where(employee => employee.Salary >= 200 ).ToList();
            //List<Employee> EmployeeWithoutBonus = Employees.Where(employee => employee.Salary < 200 ).ToList();
            //Employee employeeBelowAverage = Employees.First(employee => employee.Salary >= 200 );
            //Console.WriteLine("Employee below average: "+ employeeBelowAverage.Name );

            //foreach(Employee emp in EmployeeWithoutBonus)
            //{
            //    emp.Salary += 100;
            //}

            //foreach(Employee emp in EmployeeWithoutBonus)
            //{
            //    Console.WriteLine( emp.Name + emp.Salary);
            //}
            
            //------Solomon Young's Assignment
            
            
            List<Employeee> employeees = new List<Employeee>
            {
                new Employeee{ Name = "Mary", Salary = 500},
                new Employeee{ Name = "William", Salary = 350},
                new Employeee{ Name = "Martha", Salary = 900},
                new Employeee{ Name = "Frank", Salary = 750},
                new Employeee{ Name = "Chris", Salary = 400},
                new Employeee{ Name = "Patrick", Salary = 1350},
                new Employeee{ Name = "Gabriel", Salary = 800},
                new Employeee{ Name = "Tolu", Salary = 950},
                new Employeee{ Name = "Mercy", Salary = 800},
                new Employeee{ Name = "Fortune", Salary = 1750},
                new Employeee{ Name = "Dami", Salary = 100},
                new Employeee{ Name = "Opeyemi", Salary = 950},
                new Employeee{ Name = "Rhoda", Salary = 500},
                new Employeee{ Name = "Prosper", Salary = 1350},
                new Employeee{ Name = "Abel", Salary = 570},
                new Employeee{ Name = "Isaac", Salary = 250},
                new Employeee{ Name = "Cosmas", Salary = 810},
                new Employeee{ Name = "Crystabel", Salary = 2870},
                new Employeee{ Name = "Uche", Salary = 780},
                new Employeee{ Name = "Hannah", Salary = 1350},
                new Employeee{ Name = "Miracle", Salary = 920},
                new Employeee{ Name = "Judah", Salary = 750},
                new Employeee{ Name = "Kausara", Salary = 100},
                new Employeee{ Name = "Tony", Salary = 350}
            };

            //------Average Salary
            var averageSalary = employeees.Average(x => x.Salary);
            Console.WriteLine("Average Salary is: " + averageSalary);


            //------Total Count
            var totalCount = employeees.Count();
            Console.WriteLine("Total number of employeees are: " + totalCount);

            //------Employeees that earn above 200
            List<Employeee> employeeeEarningAbove200 = employeees.Where(y => y.Salary >= 200).ToList();
            Console.WriteLine("Names of all employees that earn above 200 are: ");
            foreach(var employeee in employeeeEarningAbove200)
            {
                Console.WriteLine( employeee.Name);
            }

            //------Employeees that earn below 200
            List<Employeee> employeeeEarningBelow200 = employeees.Where(b => b.Salary < 200).ToList();
            Console.WriteLine("Names of all employees that earn below 200 are: ");
            foreach(var employeee in employeeeEarningBelow200)
            {
                Console.WriteLine(employeee.Name);
            }

            //------Employeees that have "E" in their names
            List<Employeee> employeeesWithE = employeees.Where(y => y.Name.Contains("e" )).ToList();
            Console.WriteLine("Names of enployees with E in their name: ");
            foreach(var employeee in employeeesWithE)
            {
                Console.WriteLine(employeee.Name);
            }










            //foreach(int i in intNum)
            //{
            //    if (i >= 50)
            //        intNewNum.Add(i);

            //}   
            //foreach(int i in intNewNum)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
    }
}
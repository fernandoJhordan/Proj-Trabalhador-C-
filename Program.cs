using ProjetoTrabalhador.Entities.Enums;
using System; //namespace ou biblioteca system
using System.Globalization;
using ProjetoTrabalhador.Entities;


namespace ProjetoTrabalhador //declaração de namespace desse arquivo - agrupamento de classes relacionadas
{
    class Program //declaração da classe
    {
        static void Main(string[] args) //declaração padrão C# para identificar o ponto de entrada
        {
            //Recebendo os dados
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/ MidLevel/ Senior) ");
            WorkerLevel level = Enum.Parse<WorkerLevel>( Console.ReadLine() );

            Console.Write("Base salary: ");
            double baseSalary = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando os obj
            Department dept = new Department(deptName); //instanciando o obj departamento
            Worker worker = new Worker(name, level, baseSalary, dept); //passando os atributos da classe Worker + o dept instanciado

            //Perguntando quantos contratos vai ter depois ler os dados e instanciar os contratos
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse( Console.ReadLine() );

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Data (DD/MM/YYY): ");
                DateTime date = DateTime.Parse( Console.ReadLine() );

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

                Console.Write("Duration (hours): ");
                int hours = int.Parse( Console.ReadLine() );

                //instanciando um contrato
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //Adicionando o contrato instanciado ao trabalhador
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse( monthAndYear.Substring(0, 2) );
            int year = int.Parse( monthAndYear.Substring(3) );

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
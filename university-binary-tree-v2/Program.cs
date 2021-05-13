using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rector = new Position();
            rector.Name = "Rector";
            rector.Salary = 1000;
            rector.Percentage = 29;
            rector.TaxValue = Position.TaxValuCalculate(rector.Salary, rector.Percentage);

            Position viceFinanciero = new Position();
            viceFinanciero.Name = "Vicerector Financiero";
            viceFinanciero.Salary = 750;
            viceFinanciero.Percentage = 27;
            viceFinanciero.TaxValue = Position.TaxValuCalculate(viceFinanciero.Salary, viceFinanciero.Percentage);

            Position contador = new Position();
            contador.Name = "Contador";
            contador.Salary = 500;
            contador.Percentage = 24;
            contador.TaxValue = Position.TaxValuCalculate(contador.Salary, contador.Percentage);

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.Percentage = 21;
            jefeFinPosition.TaxValue = (jefeFinPosition.Salary * jefeFinPosition.Percentage) / 100;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria Financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.Percentage = 16;
            secFin1Position.TaxValue = (secFin1Position.Salary * secFin1Position.Percentage) / 100;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria Financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.Percentage = 16;
            secFin2Position.TaxValue = (secFin2Position.Salary * secFin2Position.Percentage) / 100;

            Position vicAcademicoPosition = new Position();
            vicAcademicoPosition.Name = "Vicerector Academico";
            vicAcademicoPosition.Salary = 780;
            vicAcademicoPosition.Percentage = 24;
            vicAcademicoPosition.TaxValue = (vicAcademicoPosition.Salary * vicAcademicoPosition.Percentage) / 100;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de registro Academico";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.Percentage = 22;
            jefeRegPosition.TaxValue = (jefeRegPosition.Salary * jefeRegPosition.Percentage) / 100;

            Position secGen2Position = new Position();
            secGen2Position.Name = "Secretaria General 2";
            secGen2Position.Salary = 360;
            secGen2Position.Percentage = 16;
            secGen2Position.TaxValue = (secGen2Position.Salary * secGen2Position.Percentage) / 100;

            Position secGen1Position = new Position();
            secGen1Position.Name = "Secretaria General 1";
            secGen1Position.Salary = 400;
            secGen1Position.Percentage = 17;
            secGen1Position.TaxValue = (secGen1Position.Salary * secGen1Position.Percentage) / 100;

            Position asistente2Position = new Position();
            asistente2Position.Name = "Asistente 2";
            asistente2Position.Salary = 170;
            asistente2Position.Percentage = 9;
            asistente2Position.TaxValue = (asistente2Position.Salary * asistente2Position.Percentage) / 100;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.Percentage = 1;
            mensajeroPosition.TaxValue = (mensajeroPosition.Salary * mensajeroPosition.Percentage) / 100;

            Position asistente1Position = new Position();
            asistente1Position.Name = "Asistente 1";
            asistente1Position.Salary = 250;
            asistente1Position.Percentage = 8;
            asistente1Position.TaxValue = (asistente1Position.Salary * asistente1Position.Percentage) / 100;


            UniversityTree universityTree = new UniversityTree();

            universityTree.CreatePosition(null, rector, null);
            universityTree.CreatePosition(universityTree.Root, viceFinanciero, rector.Name);

            universityTree.CreatePosition(universityTree.Root, contador, viceFinanciero.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contador.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contador.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, viceFinanciero.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcademicoPosition, rector.Name);

            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcademicoPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secGen2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secGen1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asistente2Position, secGen1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asistente2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asistente1Position, secGen1Position.Name);

            Console.WriteLine("{0,30} {1,10} {2,10} {3,10}", "POSITION", "SALARY", "% TAX", "TAX VALUE\n");

            universityTree.PrintTree(universityTree.Root);


            float sumSalary1 = universityTree.SumSalaries(universityTree.Root);

            Console.WriteLine("\n{0,30} {1,13}", "The sum of salaries is:", $"{sumSalary1} ");


            float higherLeft = universityTree.SalaryHigher(universityTree.Root.Left);
            float higherRight = universityTree.SalaryHigher(universityTree.Root.Right);

            if (higherLeft >= higherRight)
            {
                Console.WriteLine($"\nP 1. The higher salary is: {higherLeft} ");
            }
            else
            {
                Console.WriteLine($"\nP 1. The higher salary is: {higherRight} ");
            }


            float count1 = universityTree.Count(universityTree.Root);

            double promedio = (sumSalary1 / count1);

            promedio = Math.Round(promedio, 1);

            Console.WriteLine($"\nP 2. The average salary is: {promedio}");


            PositionNode position = universityTree.SearchNode(universityTree.Root, viceFinanciero.Name);

            float sumSalary2 = universityTree.SumSalaries(position);

            float count2 = universityTree.Count(position);
            Console.WriteLine($"\nP 3. The average salaries from position {position.Position.Name}" + $" is: {sumSalary2 / count2}");


            float sumTax = universityTree.SumTax(universityTree.Root);
            Console.WriteLine($"\nP 4.The total taxes are: {sumTax}");

            Console.ReadLine();
        }
    }
}

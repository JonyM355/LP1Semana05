using System;
using Bogus;
using Spectre.Console;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker("pt_PT");

            //Table Creation
            Table tabela = new Table();

            //Add Columns
            tabela.AddColumn("ID").Centered();
            tabela.AddColumn(new TableColumn("Nome"));
            tabela.AddColumn(new TableColumn("Job"));

            for (int i = 0; i > args.Length; i++)
            {
                int id = i;

                string person = faker.Name.FullName();

                string j = faker.Commerce.Department();

                tabela.AddRow($"{id}", $"{person}",
                                    $"{j}");
                
                AnsiConsole.Write(tabela);
            }

            //Show Table
            AnsiConsole.Write(tabela);
        }
    }
}

using System;
using System.Collections.Generic;

namespace List1_CSharp {
    class Program {
        static void Main(string[] args) {
            Funcionario funcionario;

            Console.WriteLine("How many employees will be registered?");
            int qtdeEmpregados = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= qtdeEmpregados; i++) {
                Console.WriteLine("\nEmpregado " + i);

                Console.WriteLine("\nDigite o ID do funcionário.");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o nome do funcionário");
                string nome = Console.ReadLine();

                Console.WriteLine("\nDigite o salário do funcionário");
                float salario = float.Parse(Console.ReadLine());

                funcionario = new Funcionario(id, nome, salario);
                funcionarios.Add(funcionario);
            }

            Console.WriteLine("\n\nDigite o ID do funcionário que terá o salário aumentado");
            int id2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a porcentagem do aumento");
            float porcentagem = float.Parse(Console.ReadLine());

            funcionario = funcionarios.Find(x => x._id == id2);
            funcionario.aumentarSalario(porcentagem);

            Console.WriteLine("\n\n\nLista de funcionários atualizada");

            foreach (Funcionario func in funcionarios) {
                Console.WriteLine(func.ToString());
            }
        }
    }
}

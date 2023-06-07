using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Leitura
{
    class Program
    {

        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            int idade;
           
           

            
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Agora digite o seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Agora digite a sua idade: ");
            idade = Int32.Parse (Console.ReadLine());

            //Serve para ler oque o usuario digitou;
            //SEMPRE RETORNA UM TEXTO
            Console.ReadLine();

            // Serve para transformar o texto em número
            //Int32.Parse();
            
            Console.WriteLine($"Seja Bem-Vindo(a) {nome} {sobrenome}, você tem {idade} anos.");
            Console.WriteLine($"Daqui a 5 anos você terá {idade + 5} anos");
            Console.WriteLine($"Você nasceu no ano de { 2023 - idade}");



            Console.ReadKey();

        }

        void Revisao()
        {

            float lanche = 8.00f;
            float salsicha = 1.50f;
            float hamburguer = 2.00f;
            float requeijao = 1.50f;
            float bacon = 2.00f;
            float xtudo = hamburguer + lanche + bacon + salsicha;
            float dog = (salsicha * 2) + requeijao + lanche;
            float moda = lanche + salsicha + hamburguer + requeijao + bacon;
            float combo = dog + moda + xtudo;
            Console.WriteLine("Cardápio do Adeylson Lanches");
            Console.WriteLine("Valores");
            Console.WriteLine($"X-Rato = Hamburguer, Bacon e Salcicha - R${xtudo}");
            Console.WriteLine($"Dog-Salsicha Cremoso = 2 Salsichas e Requeijão - R${dog}");
            Console.WriteLine($"Moda de la casa = Hamburguer, Salsicha, Requeijão e Bacon - R${moda}");
            Console.WriteLine($"\n\n\nCombo Ratinho = X-Rato, Dog-Salsicha Cremoso e Moda de la casa - R${combo}");


            Console.ReadKey();


        }

    }
}

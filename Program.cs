using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV07
{
    class Program
    {



        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("digite um numero");
            numero = Int32.Parse(Console.ReadLine());
            if (numero > 100)
            {
                Console.WriteLine(numero + 150);
            }
            Console.ReadKey();
            atv02();
            Atv03();
            atv04();
            atvextra();
            Console.ReadKey();
        }
        static void atv02()
        {
            Console.WriteLine("Digite o nome do aluno :");
            string nome = Console.ReadLine();
            Console.WriteLine("digite sua nota atual");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 6.0)
            {
                Console.WriteLine($"parabens você esta aprovado aluno {nome} com a nota {nota}");

            }
            else
            {
                Console.WriteLine($"Infelizmente o aluno {nome} foi reprovado com a nota {nota} ");
            }
            Console.ReadKey();
        }
        static void Atv03()
        {
            double nota;
            double nota2;
            Console.WriteLine("digite a nota do bimestre passado:");
            nota = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do bimestre atual");
            nota2 = double.Parse(Console.ReadLine());
            double media = (nota + nota2) / 2;
            if (media > 6.0)
            {
                Console.WriteLine($"a {media} é maior que a media minima(6.0)");
                

            }
            if (media == 6.0)
            {
                Console.WriteLine($"a {media} é igual a media minima (6.0)");
                
            }
            if (media < 6.0)
            {
                Console.WriteLine($"a {media} é menor que a media minima (6.0)");
               
            }
        }
        static void atv04()
        {
            Console.WriteLine("digite a sua nota do ano retrasado");
            double nota = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a sua nota do ano passado");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a sua nota do ano atual");
            double nota3 = double.Parse(Console.ReadLine());
            double notafinal;
            if(nota > nota2)
            {
                notafinal = nota;
                Console.WriteLine($"o numero maior é {nota}");
                return;

            }if(nota > nota3)
            {
                notafinal = nota;
                Console.WriteLine($"o numero maior é {nota}");
                return;
            }if(nota2 > nota)
            {
                notafinal = nota2;
                Console.WriteLine($"o numero maior é {nota2}");
                return;
            }if (nota2 > nota3)
            {
                notafinal = nota2;
                Console.WriteLine($"o numero maior é {nota2}");
                return;
            }if(nota3 > nota)
            {
                notafinal = nota3;
                Console.WriteLine($"o numero maior é {nota3}");
                return;
            }if(nota3 > nota2)
            {
                notafinal = nota3;
                Console.WriteLine($"o numero maior é {nota3}");
                return;

            }

            
             




        }
        static void atvextra()
        {
            Console.WriteLine("digite um numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite mais um numero");
            int numero2 = int.Parse(Console.ReadLine());
            int valorfinal = numero1 / numero2;
            if (valorfinal < 0)
            {
                Console.WriteLine($"a divisão do {numero1} pelo {numero2} é exata");
            }
            else
            {
                Console.WriteLine("a divisão digita não é exata");
            }
            
        }
    }
}
    
          
           
           

         
        









    


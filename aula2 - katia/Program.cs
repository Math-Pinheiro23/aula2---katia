using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2___katia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração e instanciação de objeto
            Produto prod = new Produto();

            Console.WriteLine("Digite o codigo do prouduto: ");
            prod.setCodigo(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a descrição do prouduto: ");
            prod.setDescricao(Console.ReadLine());

            Console.WriteLine("Digite a categoria do prouduto: ");
            prod.setCategoria(Console.ReadLine());

            Console.WriteLine("Digite o valor do prouduto: ");
            prod.setValor(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Codigo = " + prod.getCodigo() + "\nDescrição: " +
                prod.getDescricao() + "\nCategoria = " + prod.getCategoria() +
                "\nValor = " + prod.getValor().ToString("C"));

            Console.ReadKey();

        }
    }
}

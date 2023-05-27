namespace Ejercicio20b.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;

            Console.Write("Ingres el primer numero: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Ambos numeros son iguales");
            }
            else
            {
                if (numero1 > numero2)
                {
                    Console.Write($"{numero1} mayor que {numero2}");
                }
                else
                {
                    Console.Write($"{numero2} mayor que {numero1}");
                }
            }
        }
    }
}
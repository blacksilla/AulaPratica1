namespace AulaPratrica1.Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza um número");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("O número introduzido é par");
            }
            else
            {
                Console.WriteLine("O número introduzido é impar");
            }
        }
    }
}
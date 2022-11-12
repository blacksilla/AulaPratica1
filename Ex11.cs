namespace AulaPratica1.Ex11
{
    internal class Ex11
    {
        static void Main(string[] args)
        {
           
            int num1;
            int num2;

            Console.WriteLine("Insira um número");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número");
            num2= int.Parse(Console.ReadLine());

            //se o numero 1 for maior que o 2
            if (num1 > num2)
            {
                Console.WriteLine("Os números divisiveis por 5 são: ");
                while (num1 >= num2) //enquanto o n1 for maior que o n2
                {
                    if (num2 % 5 == 0) //e o resto da divisão por 5 for 0
                    {
                        Console.WriteLine(num2); //escreve o numero na consola
                        num2++; //adiciona 1 unidade
                    }
                    else // se o resto não for 0, adiciona apenas 1 unidade (passar ao numero seguinte)
                    {
                        num2++;
                    }
                }
            }
            else //se o numero 2 for maior que o 1
            {
                Console.WriteLine("Os números divisiveis por 5 são: ");
                while (num1 <= num2)
                {
                    
                    if(num1%5== 0) {
                        Console.WriteLine(num1);
                        num1++;
                    }
                    else
                    {
                        num1++;
                    }
                    
                }
            }
        }
    }
}
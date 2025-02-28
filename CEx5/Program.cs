namespace CEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Digite o segundo número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());//outra forma de converter

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);
            int menor = Math.Min(num1, num2);
            menor = Math.Min(maior, num3);
            Console.WriteLine($"\nO Número {maior} é o maior valor");
            Console.WriteLine($"\nO Número {menor} é o menor valor");
        }
    }
}

namespace CEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());//outra forma de converter

            int maior = Math.Max(num1, num2);
            Console.WriteLine($"\nO Número maior é {maior} é maior"); //\n quebra de linha
            ;
        }
    }
}

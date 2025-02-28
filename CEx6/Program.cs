namespace CEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome");
            string nome = Console.ReadLine()!;
            Console.Write("\nInforme o número de horas trabalhadas: ");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o valor da hora trabalhada: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double resultado = quantidadeHoras * valorHora;

            Console.WriteLine($"\nA renda total de  {nome} é R${resultado:F2}");
        }
    }
}

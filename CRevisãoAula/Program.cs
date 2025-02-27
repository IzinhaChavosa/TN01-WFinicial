namespace CRevisãoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Revisão de aula.
            Console.WriteLine("Digite 1° nota do aluno(a)");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite 2° nota do aluno(a)");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;


            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media < 5)
            { 
            Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }

        }
    }
}

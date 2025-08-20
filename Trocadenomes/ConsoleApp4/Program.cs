namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
            string nome1, nome2, nome3, nome4, auxiliar;

            Console.WriteLine("Codigo de pedir nomes");

            Console.Write("Informe o primeiro nome: ");
            nome1 = Console.ReadLine();

            Console.Write("Informe o segundo nome: ");
            nome2 = Console.ReadLine();
          
            Console.Write("Informe o terceiro nome: ");
            nome3 = Console.ReadLine();

            Console.Write("Informe o quarto nome: ");
            nome4 = Console.ReadLine();


            //mecanismo para inverter nomes
            auxiliar = nome1;
            nome1 = nome4;
            
            nome4 = auxiliar;
            auxiliar = nome2;

            nome2 = nome3;

            nome3 = auxiliar;

            Console.WriteLine("Nomes invertidos");

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            
            Console.ReadKey();
        }
    }
}

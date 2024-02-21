namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade;

            Console.WriteLine("Escreva seu nome. ");
            nome = Console.ReadLine();
            Console.WriteLine("escreva sua idade. ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva sua cidade. ");
            cidade = Console.ReadLine(); 

            
            Console.WriteLine(" \nnome : {0} \nidade: {1} anos \ncidade: {2}", nome, idade, cidade);
        
        }
    }
}

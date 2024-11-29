namespace COR_TEXT_M9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            
            Console.WriteLine("bom dia alunos de psi");
            Console.WriteLine("insira o titulo do livro ");
            livro.setTitulo( Convert.ToString(Console.ReadLine()));
            Console.WriteLine("insira o autor do livro ");
            livro.setAutor(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("insira o ano do livro ");
            livro.setAnoPublicacao(Convert.ToInt32(Console.ReadLine()));

            livro.ExibirInformacoes();


        }
    }
}
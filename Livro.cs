using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR_TEXT_M9
{


    internal class Livro
    {
        /*   1 qestao do teste ok 
    +-------------------------------------------+
| - titulo: string | // Atributo privado
| - autor: string | // Atributo privado
| - anoPublicacao: int | // Atributo privado
+-----------------------------------------

    */
        private string _titulo;
        private string _autor;
        private int _anoPublicacao;
 /*
  * 
  * + getTitulo(): string | // Método público para obter título X
| + setTitulo(titulo: string): void | // Método público para definir título X
| + getAutor(): string | // Método público para obter autor X 
| + setAutor(autor: string): void | // Método público para definir autorx
| + getAnoPublicacao(): int | // Método público para obter ano de publicação X 
| + setAnoPublicacao(ano: int): void | // Método público para definir ano de publicação com validaçãox
| + Livro(titulo, autor, ano) | // Construtor públicox
| + ExibirInformacoes(): void | // Método público para exibir informações
 * 
 */

        public string getTitulo()
        {

            return _titulo;
        }
        public string getAutor()
        {
            return _autor;
        }
        public int getAnoPublicacao()
        {
            return _anoPublicacao;
        }

        //setTitulo(titulo: string): void

        public void setTitulo(string titulo)
        {
            _titulo = titulo;
        }

        public void setAutor(string autor   )
        {
            _autor = autor;
        }

        //| + setAnoPublicacao(ano: int): void | // Método público para definir ano de publicação com validação

        public void setAnoPublicacao(int ano)
        {
            if (ano > 0)
            {
                _anoPublicacao = ano;
            }
            else
                Console.WriteLine("nao pode inserir anos <=0");
        }

        public Livro(string titulo="", string autor="", int anoPublicacao=-1)
        {
            _titulo = titulo;
            _autor = autor;
            _anoPublicacao = anoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Título: " +_titulo+ " , Autor: " + _autor + " , Ano: " + _anoPublicacao);
        }
    }
}

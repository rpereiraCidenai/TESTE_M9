# TESTE_M9

Este projeto foi desenvolvido como parte de uma avaliação prática do Módulo 9 da disciplina de PSI, na **Escola Profissional de Serviços de Cidenai**. O objetivo é implementar uma classe `Livro` em C#, cumprindo os requisitos estabelecidos no enunciado.

## Requisitos da Classe Livro

- **Atributos Privados:**
  - `titulo` (string)
  - `autor` (string)
  - `anoPublicacao` (int) *(com validação para valores superiores a 0)*

- **Métodos Públicos:**
  - **`getTitulo()`**: Retorna o título do livro.
  - **`setTitulo(string titulo)`**: Modifica o título do livro.
  - **`getAutor()`**: Retorna o autor do livro.
  - **`setAutor(string autor)`**: Modifica o autor do livro.
  - **`getAnoPublicacao()`**: Retorna o ano de publicação do livro.
  - **`setAnoPublicacao(int ano)`**: Modifica o ano de publicação, mas antes valida se o ano é maior que 0. Caso contrário, exibe uma mensagem de erro.

- **Validação do Ano de Publicação:**
  O método `setAnoPublicacao(int ano)` verifica se o ano fornecido é maior que 0 antes de atribuí-lo ao atributo. Caso contrário, o valor não será definido, garantindo que apenas anos válidos sejam aceites.

- **Construtor:**  
  Inicializa os atributos `titulo`, `autor` e `anoPublicacao`.

## Programa Principal

- Criação de um objeto da classe `Livro`.
- Utilização dos métodos para definir e obter valores.
- Chamada ao método `ExibirInformacoes()` para apresentar os dados na consola.

## Como Executar

1. Clone o repositório:
    ```bash
    git clone https://github.com/rpereiraCidenai/TESTE_M9.git
    ```
2. Abra o projeto no Visual Studio.
3. Compile e execute o projeto.

---

**Desenvolvido por:** [rpereiraCidenai](https://github.com/rpereiraCidenai/TESTE_M9)  
**Escola Profissional de Serviços de Cidenai**

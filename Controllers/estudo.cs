
/*

    O que é API:
        é uma interface (ponte ou um canal de comunicação) de aplicação sem parte visual.
    Dê um exemplo de outra API que você pode usar
        via.cep que é uma interface gratuita e que podemos utilizar através do JSON.
    Pra que serve:
        para comunicar o front-end com o back-end.
    Quem consome (quem pede os dados para) essa API:
        front-end
    O que são verbos ou métodos HTTP:
        são tipos de requisições.
        Usamos no back-end para definir oq é permitido na rota.
        Usamos no front-end pra comunicar com o backend.
            Frontend: [Entra na casa backend através da rota]
            Frontend: [Bate na porta POST (método HTTP POST)]
            Backend: [Deixa o Frontend entrar OU se for uma porta errada: Error 405 Method Not Allowed]
            Frontend: "OW BACK, esse cara tá querendo logar aqui, ele pode logar com esse usuario e senha?"
                {
                    "user": "user@mail.com",
                    "pass": "1234"
                }
            Backend: "E ae mano front, não, esse cara digitou os dados errados"
            Backend: [devolve um JSON falando do erro e devolve um Status HTTP 403 OU 400]
    Quais são os verbos HTTP disponíveis: 
        GET, POST, PUT, DELETE, (OUTROS nao muito usados: PATCH e OPTIONS)
    Quem converte o objeto de c# para JSON 
        é o próprio framework ASP .NET Core 
    Qual a diferença entre um objeto e um array em JSON
        {
            name: "Gabriel"
            name: "Noemi"
        }

        // Array com duas strings
        ["Gabriel", "Noemi"]

        // Array de objetos
        [
            {
                // chave : valor
                "nome": "Gabriel"
            },
            {
                "nome": "Noemi
            }
        ]
    30/04
    Criando API do zero ASP NET CORE 3.1, vscode ou vs
    vou te testar


*/

/*
      Banco de dados (BD): Local para guardar informações
       "1 ou N" Tabelas = Lista de registros
         Campos/Colunas   = chaves (ex: ID e Title)
          Registros/Linhas = valores (ex: 1 - veículos, 2 - imóveis)

             Coluna           Coluna
       +----------------+----------------+
       |       ID       |     Title      |
       +----------------+----------------+
 Linha |       1        |    Veiculos    |
       +----------------+----------------+
 Linha |       2        |    Imoveis     |
       +----------------+----------------+
                        
         Context = seu banco de dados
      .Categories = sua tabela

      Classe Category

    EntityFrameworkCore / EFCore / "lê-se 'êntiti'" = ORM = mapeamento objeto-relacional, ou seja, converte
  bd para contextos, tabelas para classes, registros no bd para objetos
                
*/


using Exlistalivros;


//Atividade Crie um novo projeto para um programa que armazene em uma lista informações sobre livros, com Nome, Editora, Autor e Número de páginas
//Preencha essa lista com no mínimo 5 livros e ao final percorra essa lista e imprima as informações do livro com o maior número de páginas


List<Books> livros = new List<Books>();


livros.Add(new Books(){
   Nome = "Livro1",
   Editora = "Editora1",
   Autor = "Autora1",
   Paginas = 100
});
livros.Add(new Books(){
   Nome = "Livro2",
   Editora = "Editora2",
   Autor = "Autora2",
   Paginas = 150
});
livros.Add(new Books(){
   Nome = "Livro3",
   Editora = "Editora3",
   Autor = "Autora3",
   Paginas = 200
});
livros.Add(new Books(){
   Nome = "Livro4",
   Editora = "Editora4",
   Autor = "Autora4",
   Paginas = 250
});
livros.Add(new Books(){
   Nome = "Livro5",
   Editora = "Editora5",
   Autor = "Autora5",
   Paginas = 300
});

int maiorvalor = 0;
string maiorlivro = "";

do{
   

   Console.WriteLine("Digite o Nome");
   string? nome = Console.ReadLine();
   Console.WriteLine("Digite a editora");
   string? editora = Console.ReadLine();
   Console.WriteLine("Digite a autora");
   string? autora = Console.ReadLine();
   Console.WriteLine("Digite o número de páginas");
   int pagina = Console.ReadLine();


   livros.Add(new Books(){
      Nome = nome,
      Editora = editora,
      Autor = autora,
      Paginas = pagina
   });

   
   Console.WriteLine("Digite 0 para quebrar o loop ou 1 para continuar");
   int validador = Console.ReadLine();

   if(validador == 0){
      break;
   }
}
while(true);

foreach (livro l in livros)
{
      if(l.pagina > maiorvalor){
         maiorvalor = l.pagina;
         maiorlivro = l.Nome;
      }
}

Console.WriteLine($"O Livro com mais páginas é {maiorlivro}");
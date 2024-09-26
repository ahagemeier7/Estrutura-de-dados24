// Exemplo de uma agenda telefonica
using System.Collections;

Hashtable phoneBook = new Hashtable(){
    //{ "Chave", "Valor" },
    {"Thomazzi", "49-9961-0150"},
    {"Mauricio Gonzatto", "49-99975-8575"},
    {"Gabriel Bianchi","49-99105-8904"}
};


//É possivel adicionar elementos de diversas formas pelo próprio índice chave inexistente
phoneBook["Thiago Padilha"] = "49-99176-8275";
// Ou pelo método Add
phoneBook.Add("Marcos Henrique", "49-99202-6169");

// Entretanto, a tabela Hash verifica se há duplicidade de chave e pode lançar uma Exception
try {

    phoneBook.Add("Mauricio Gonzatto","49-99975-5875");
}catch(Exception ex){
    
    Console.WriteLine($"Erro ao tentar incluir valor repetido.");
    Console.WriteLine(ex.Message);
}

//Percorrendo itens da HashTable
Console.WriteLine("Agenda telefonica:");
if(phoneBook.Count == 0)
    Console.WriteLine("A agenda está vazia");
else
    foreach(DictionaryEntry entry in phoneBook )
        Console.WriteLine($"{entry.Key} : {entry.Value}");
    

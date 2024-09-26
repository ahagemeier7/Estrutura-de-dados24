// diferente da tabela Hash, o Dictionary  nos permite especificar o tipo de dado que sera utilizado nos pares
//key -> value isso nos fornece uma estrutura fortemente tipada
using Dicionario;



Dictionary<string, string> dictionary = new Dictionary<string,string>(){
    {"Chave1","Valor1"},
    {"Chave2","Valor2"}
};

//obter valor do Dictionary
string val = dictionary["Chave1"];
try {
    val = dictionary["Chave3"];
}catch(Exception ex){
    Console.WriteLine("Erro ao obter valor de Chave3");
    Console.WriteLine(ex.Message);
}


//Verificando se a chave existe antes de acessar para evitar erros e prejuizos de execução
if(dictionary.ContainsKey("Chave2"))
    Console.WriteLine($"Chave2:{dictionary["chave2"]}");


//outra forma de eu ter o valor e evitar erro
dictionary.TryGetValue("chave4", out string? valor);
if(val is not null){
    Console.WriteLine($"Chave4:{valor}");
}

// Podemos adicionar da mesma forma pela chave inexistente 
dictionary["Chave0"] = "Valor0";

//Percorrer o dicinário
foreach(KeyValuePair<string, string> kvp in dictionary){
    Console.WriteLine(kvp.Key, kvp.Value);
}


//Utilizando tipo

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();

dicPessoa.Add(1,new Pessoa(){
    Id = 1, 
    Name = "Mauricio Gonzatto",
    BirthDate = new DateTime(1984,7,5)
    }
);
dicPessoa.Add(2,new Pessoa(){
    Id = 1, 
    Name = "Joaozinho",
    BirthDate = new DateTime(1900,12,5)
    }
);


foreach(KeyValuePair<int, Pessoa> kvp in dicPessoa){
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Name);
}
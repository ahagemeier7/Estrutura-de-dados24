using System.Security.Cryptography.X509Certificates;
using Prateleira;
Dictionary<string, Produtos> prateleiras = new Dictionary<string, Produtos>();

prateleiras.Add("A1",new Produtos(){
    Id = 1, 
    Nome = "Batata"
    }
);
prateleiras.Add("A2",new Produtos(){
    Id = 2, 
    Nome = "Arroz"
    }
);

bool x = false;
while (x == true){
    Console.WriteLine("Digite o Código do produto para procurar");
    try{    
        string? validador = Console.ReadLine();
        int.TryParse(validador, out int codigo);
    }catch(Exception ex){
        Console.WriteLine("Código Invalido! digite outro");
    }
    prateleiras.TryGetValue(codigo, out int valor);
    if(valor is not null){

    }
}

    




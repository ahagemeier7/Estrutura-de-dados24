using System.Security.Cryptography.X509Certificates;
using Prateleira;
//Dictionary<string, Produtos> prateleiras = new Dictionary<string, Produtos>();

// prateleiras.Add("A1",new Produtos(){
//     Id = 1, 
//     Nome = "Batata",
//     Quantidade = 5
//     }
// );
// prateleiras.Add("A2",new Produtos(){
//     Id = 2, 
//     Nome = "Arroz",
//     Quantidade = 5
//     }
// );
// Produtos prodobj;
// bool x = true;
// while (x == true){
//     Console.WriteLine("Digite o Código do produto para procurar");
//     try{    
//         string? validador = Console.ReadLine();
//         if (validador != null){
//             prateleiras.TryGetValue(validador, out prodobj!);
//         }else{
//             Console.WriteLine("Código Invalido! digite outro");    
//         }

//     }catch(Exception ex){
//         Console.WriteLine("Código Invalido! digite outro");
//     }
    

// }

    

Dictionary<string, string> prateleiras = new(){
    { "1", "A1" },
    { "2", "A1" },
    { "3", "A1" },
    { "4", "A1" },
    { "5", "A1" },
    { "6", "A2" },
    { "7", "A8" },
    { "8", "C1" },
    { "9", "C2" },
    { "10", "B8" },
    { "11", "C8" },
    { "12", "A3" },
    { "13", "B5" },
    { "14", "B7" },
    { "15", "A5" }
};

bool x = true;
while (x == true){
    Console.WriteLine("Digite o Código do produto para procurar");
    string? validador = Console.ReadLine();
    Console.WriteLine(validador);
        if (validador == null){
            Console.WriteLine("Código Invalido! digite outro");  
            
        }else{
            if(prateleiras.ContainsKey(validador!)){
                Console.WriteLine("Código Invalido! digite outro"); 
            }else{
                Console.WriteLine($"{validador}");
                Console.WriteLine($"O produto está na prateleira {prateleiras[validador]}");
                x = false;
            }

            
        }
}

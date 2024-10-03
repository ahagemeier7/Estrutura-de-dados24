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

    

Dictionary<string, string> prateleiras = new Dictionary<string, string>();

prateleiras.Add("1","A1");
prateleiras.Add("2","A1");
prateleiras.Add("3","A1");
prateleiras.Add("4","A1");
prateleiras.Add("5","A1");
prateleiras.Add("6","A2");
prateleiras.Add("7","A8");

bool x = true;
while (x == true){
    Console.WriteLine("Digite o Código do produto para procurar");
    string? validador = Console.ReadLine();
        if (validador != null){
            prateleiras.TryGetValue(validador, out prodobj!);
        }else{
            Console.WriteLine("Código Invalido! digite outro");    
        }
}

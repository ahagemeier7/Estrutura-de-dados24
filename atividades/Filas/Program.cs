//Uma fila é a estrutura de dados que pode ser aplicada para representar a fila de atendimento da cantina
// as pessoas que chegam entram no final da fila, E as primeiras que chegaram são as primeiras a serea atendidas.

// a função ENQUEUE é responsavel por adicionar novos elementos a fila

//A função DEQUEUE é responsavel por tirar elementos da fila

// Desta forma obedece o principio do FIFO => First In First Out


using Filas;

Random random = new Random();

CallCenter center = new CallCenter();
center.Call(1234);
center.Call(1369);
center.Call(2468);
center.Call(1478);

while(center.AreWaitingCalls()){
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now.ToString("HH:mm:ss")} 
                    Chamado: #{call.Id} 
                    De: {call.ClientId} 
                    Atendido por: {call.Consultant}");
    Thread.Sleep(random.Next(1000, 10000));
    center.end(call);
    Console.WriteLine(
        @$"Chamado: {call.Id} 
                Encerrado as:{call.EndTime}");
} 
using Aula01;

// Comentario 1 linha
/*
Comentário de multiplas linhas
*/

//Declarando Variáveis

//int number;

//Atribuindo valor
//number = 10;

//Declarando constante
const int DAYS_IN_WEEK = 7;

//imprimindo string concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias ");

// new TipoEnum invoca o método construtor do objeto
// Toda a classe tem o seu construtor padrão implicito sem argumentos
// É possivel sobreescrever esse método, especificando argumentos.
// todavia se o fizermos perdemos o original implicito e precisaremos
// Defini-lo explicitamente
TipoEnum tipoenumerador = new TipoEnum();

TipoEnum.Language enumEnglish = tipoenumerador.GetLanguageEnum("inglês");
Console.WriteLine($"O eunum de english é {enumEnglish}");
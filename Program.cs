
//float float1 = 10.1f;  (Float = 4 Bytes)
//double double1 = 10.1;  (Float = 8 Bytes)
//decimal decimal1 = 10.1m;  (Float = 16 Bytes)

//bool possuiCnh = false;

//char letra = 'A';  (Char Permite Só Uma Letra Dentro)

//var variavel = 15; (O var Não É Necessario Especificar O Tipo De Variavel, Entao Ele Pode Conter Um Char, False, Etc)



//string nome = "Ana";
//int idade = 34;

//Console.WriteLine("Meu Nome é " + nome +" e tenho " + idade + " anos");
//Console.WriteLine($"Meu Nome é {nome} e tenho {idade} anos");

//bool booleana1 = true;
//bool booleana2 = true;

//if(booleana1 || booleana2) {   // Tambem podemos utilizar: ==, !=, >, <, >=, <= , &&, || , !
//Console.WriteLine("É Igual ");}

//void Saudacao(int idade1, int idade2){
//  Console.WriteLine($"{idade1} - {idade2}");}
//Saudacao(10, 30);

/*int idade = 11;
if (idade >= 18){
    Console.WriteLine("Maior de Idade");
}else{
    Console.WriteLine("Menor de Idade");
}
*/


/* string cor = "azul";

    switch(cor)
    {
        case "azul": 
        Console.WriteLine("A Cor é Azul");
        break;
        case "vermelho":
        Console.WriteLine("A Cor é Vermelho");
        break;
    default:
        Console.WriteLine("Outra Cor");
        break;
    } 
*/


/* for (int i = 0; i < 5; i++) {
    Console.WriteLine($"Número: {i}");  
}
*/



/*int j = 0;

while(j < 5){
    Console.WriteLine(j);
    j++;
}
*/
/*int j = 0;  
do 
{
    Console.WriteLine("Executado Pelo Menos Uma Vez");
    j++;
}while (j < 5);
*/


/*int[] numeros = {1, 2, 3};
foreach (int numero in numeros){
   Console.WriteLine(numero);}
*/

using flavio;

Pessoa p = new Pessoa();
p.Nome = "Flavio Noim";
p.Idade = 16;
p.Apresentar();

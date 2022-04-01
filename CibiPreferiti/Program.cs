// See https://aka.ms/new-console-template for more information
string[] classificaDeiMieiCibiPreferiti = { "Pizza", "Sushi", "Gelato", "Hamburger", "Cioccolato", "Pollo", "Yogurt", "Formaggio" };
Console.WriteLine($"Nella seguente classifica abbiamo: {classificaDeiMieiCibiPreferiti.Length} posizioni");

for (int i = 0; i < classificaDeiMieiCibiPreferiti.Length; i++)
{
Console.WriteLine($"Alla posizione {i+1} troviamo: {classificaDeiMieiCibiPreferiti[i]}");

}

var primaPoszione = classificaDeiMieiCibiPreferiti[0];
var ultimaPosizione = classificaDeiMieiCibiPreferiti[classificaDeiMieiCibiPreferiti.Length - 1];
Console.WriteLine("Il cibo nella prima posizione è : " + primaPoszione);
Console.WriteLine("Il cibo nell'ultima posizione è : " + ultimaPosizione);

var mediana = classificaDeiMieiCibiPreferiti[classificaDeiMieiCibiPreferiti.Length / 2];
var secondaMedianaCasoPari = classificaDeiMieiCibiPreferiti[(classificaDeiMieiCibiPreferiti.Length / 2) - 1];

if (classificaDeiMieiCibiPreferiti.Length %2 == 0)
{
    Console.WriteLine($"I cibi nella posizione centrale della classifica sono: {mediana} e {secondaMedianaCasoPari}");
}
else
{
    Console.WriteLine($"Il cibo nella posizione centrale della classifica è : {mediana}");
}


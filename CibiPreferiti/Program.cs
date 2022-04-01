// See https://aka.ms/new-console-template for more information
string[] arrayDeiMieiCibiPreferiti = { "Pizza", "Sushi", "Gelato", "Hamburger", "Cioccolato", "Pollo", "Yogurt", "Formaggio" };
Console.WriteLine("La lunghezza dell'array è : " + arrayDeiMieiCibiPreferiti.Length);

for (int i = 0; i < arrayDeiMieiCibiPreferiti.Length; i++)
{
Console.WriteLine($"Alla posizione {i+1} troviamo: {arrayDeiMieiCibiPreferiti[i]}");

}

var primaPoszione = arrayDeiMieiCibiPreferiti[0];
var ultimaPosizione = arrayDeiMieiCibiPreferiti[arrayDeiMieiCibiPreferiti.Length - 1];
Console.WriteLine("Il cibo nella prima posizione è : " + primaPoszione);
Console.WriteLine("Il cibo nell'ultima posizione è : " + ultimaPosizione);

var mediana = arrayDeiMieiCibiPreferiti[arrayDeiMieiCibiPreferiti.Length / 2];
var mediana2 = arrayDeiMieiCibiPreferiti[(arrayDeiMieiCibiPreferiti.Length / 2) - 1];

if (arrayDeiMieiCibiPreferiti.Length %2 == 0)
{
    Console.WriteLine($"I cibi nella posizione centrale della classifica sono: {mediana} e {mediana2}");
}
else
{
    Console.WriteLine($"Il cibo nella posizione centrale della classifica è : {mediana}");
}


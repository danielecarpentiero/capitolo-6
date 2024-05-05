/* Commentare tutto e lasciare decommentato l'esercizio che si vuole testare */

string language = "ita";
var greeting = language switch
{
    "eng" => "hello",
    "spa" => "hola",
    "ita" => "ciao",
    _ => "lingua non presente."
};
Console.WriteLine($"Greeting: {greeting}");

int[] num = { 2, 3, 4, 5, 6 };

int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum += num[i];
}
Console.WriteLine(sum);

int j = 0;
while (j < num.Length)
{
    j++;
    Console.WriteLine("il numero è {0}", j);
}
Console.WriteLine("fine ciclo while con {0}", j);

int[] array = new int[10];

for (int index = 0; index < array.Length; index++)
{
    Console.WriteLine(index);
}

int[,] matrice = new int[10, 10];
for (int riga = 0; riga < matrice.GetLength(0); riga++)
{
    for (int colonna = 0; colonna < matrice.GetLength(1); colonna++)
    {
        matrice[riga, colonna] = riga * colonna;
        Console.Write("{0, 5}", matrice[riga, colonna]);
    }
    Console.WriteLine();
}

object test = 1;

var res = test switch
{
    string s => "ciao",
    int i => "numero",
    _ => "altro",
};
Console.WriteLine(res);

/* Esercizio 1 */
int[] arr = { 1, 2, 3 };

Console.WriteLine("inserisci un numero.");
string? input = Console.ReadLine();
int valor = Convert.ToInt32(input);

int[] arr2 = new int[4];
arr.CopyTo(arr2, 0);
arr2[3] = valor;
Console.WriteLine("Ecco il tuo nuovo array:");

for (int i = arr2.Length - 1; i >= 0; i--)
{
    Console.WriteLine(arr2[i]);
}

/* Esercizio 2 */

Console.WriteLine("Inserisci quanti numeri vuoi");
bool exit = false;
int sum = 0;

while (!exit)
{
    string? input = Console.ReadLine();

    if (input?.ToUpper() == "X")
    {
        exit = true;
    }
    else
    {
        int num;
        if (int.TryParse(input, out num))
        {
            sum += num;
        }
        else
        {
            Console.WriteLine("input non valido. inserisci un numero o premi x per uscire.");
        }
    }
}
Console.WriteLine("La somma è {0}", sum);
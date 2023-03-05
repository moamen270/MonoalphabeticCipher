Console.WriteLine("Monoalphabetic Cipher Encryption / Decryption");

var rnd = new Random();
var randomNumbers = Enumerable.Range(0, 26).OrderBy(x => rnd.Next()).Take(26).ToList();
Console.WriteLine();
foreach (var randomNumber in randomNumbers)
{
    Console.Write(randomNumber + " ");
}
Console.WriteLine();
char[] Alpha = new char[26];
char[] Key = new char[26];
char letter = 'A';
for (int i = 0; i < 26; i++)
{
    Alpha[i] = letter;
    letter++;
}

letter = 'A';
for (int i = 0; i < 26; i++)
{
    Key[randomNumbers[i]] = letter;
    letter++;
}

foreach (char c in Alpha)
    Console.Write(c + " ");

Console.WriteLine();

foreach (char c in Key)
    Console.Write(c + " ");
Console.WriteLine();

// Encryption
Console.WriteLine();
Console.WriteLine("Enter the message:");
var message = Console.ReadLine();
var number = 0;
char[] cypher = new char[message.Length];
int n = 0;
foreach (var item in message.ToUpper())
{
    number = item;
    cypher[n] = Key[number - 65];
    n++;
}

Console.WriteLine("Encryption:");
Console.WriteLine(cypher);

// Decryption
char[] plane = new char[message.Length];
n = 0;
foreach (var item in cypher)
{
    var find = Key.ToList().FindIndex(x => x == item);
    plane[n] = Alpha[find];
    n++;
}
Console.WriteLine("Decryption:");
Console.WriteLine(plane);
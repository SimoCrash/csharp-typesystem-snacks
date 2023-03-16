//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
using System.Security.Cryptography.X509Certificates;

snack6();

void snack1()
{
    Console.WriteLine("Scegli due numeri, prenderò quello piu' grande");

    Console.WriteLine("Scrivi il primo e premi Enter");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Scrivi il secondo e premi Enter");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int maggiore = num1 > num2 ? num1 : num2;

    if (num1 == num2)
    {
        Console.WriteLine("scegli un numero piu' grande, sono uguali");
    }
    else
    {
        Console.WriteLine(maggiore + " è il numero piu' grande");

    }
}

void snack2()
{
    Console.WriteLine("Scrivi due parole: stamperò prima quella piu' corta e poi quella piu' lunga");
    Console.WriteLine("Scrivi la prima parola e premi Enter");
    string word1 = Console.ReadLine();

    Console.WriteLine("Scrivi la seconda parola e premi Enter");
    string word2 = Console.ReadLine();

    string longWord = word1.Length > word2.Length ? "La parola piu' corta è " + word2 + ", la piu' lunga è " + word1 : "La parola piu' corta è " + word1 + ", la piu' lunga è " + word2;

    if (word1.Length == word2.Length) 
    {
        Console.WriteLine("Controlla che una parola sia piu lunga dell'altra");
    }
    else
    {
        Console.WriteLine(longWord);
    }
}

void snack3()
{
    int sum = 0;
    Console.WriteLine("inserisci 10 numeri e io ti darò la somma");
    for (int i = 1; i <= 10; i++) 
    {
        Console.WriteLine("inserisci un numero {0}", i);
        int num = Convert.ToInt32(Console.ReadLine());
        sum += num;       
    }
    Console.WriteLine("La somma totale dei numeri inseriti è {0}", sum);
}

void snack4()
{
    int sum = 0;
    float mid = 0;
    for (int i = 2; i <= 10; i++)
    {
        sum += i;
        mid = sum / 9;
    }
    Console.WriteLine("La somma totale dei numeri da 2 a 10 è {0} e la media è {1}", sum, mid);
}

void snack5()
{
    Console.WriteLine("Inserisci un numero e premi Enter, se è dispari inserirò il numero successivo");
    int num = Convert.ToInt32(Console.ReadLine());
    int numPari = num % 2 == 0 ? num : (num + 1);
    Console.WriteLine($"Il numero che hai inserito è {numPari}");
}

void snack6()
{
    string[] invitati = { "Alessio", "Claudio", "Laura", "Marco", "Simone", "Joe", "Mary" };
    Console.WriteLine("Inserisci il tuo nome per scoprire se sei stato invitato alla festa di Gatsby");
    string nome = (Console.ReadLine());
    int presenza = Array.IndexOf(invitati, nome);
    Console.WriteLine((presenza < 0) ? "Il tuo nome è " + nome + " e non sei stato invitato" : "Il tuo nome è " + nome + " e sei stato invitato");




}
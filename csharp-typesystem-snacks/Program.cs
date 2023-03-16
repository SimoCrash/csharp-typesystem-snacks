//snack1();
//snack2();
snack3();

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
    for (int i = 1; i <= 10; i++) 
    {
        Console.WriteLine("inserisci un numero {0}", i);
        int num = Convert.ToInt32(Console.ReadLine());
        sum += num;       
    }
    Console.WriteLine(sum);
}
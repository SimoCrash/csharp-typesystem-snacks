snack1();

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
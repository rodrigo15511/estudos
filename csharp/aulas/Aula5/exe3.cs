namespace exe3
{
    class exe3
    {
    static void Teste()
    {
        System.Console.WriteLine("Digite o DDD: ");
        int ddd = int.Parse(System.Console.ReadLine());
        switch (ddd)
        {
        case int n when n >=41 && n<=46:
        System.Console.WriteLine("Párana");
        break;
        case int n when n >=51 && n<=55:
        System.Console.WriteLine("RS");
        break;
        case 61:
        System.Console.WriteLine("Brasília");
        break;
        case int n when n ==62 || n==64:
        System.Console.WriteLine("Goias");
        break;
        case int n when n >=65 && n<=66:
        System.Console.WriteLine("MT");
        break;
        case 67:
        System.Console.WriteLine("MS");
        break;
        }
    }
}
}        
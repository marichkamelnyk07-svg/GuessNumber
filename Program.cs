Console.OutputEncoding = System.Text.Encoding.UTF8;

Random random = new Random();
int guessNumber = random.Next(1, 101);
Console.WriteLine("Вгадайте число від 1 до 100 за 7 спроб");
int counter = 0;
while (counter < 7)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == guessNumber)
    {
        Console.WriteLine("Ви перемогли!");
        break;
    }
    else if (input > guessNumber)
    {
        {
            Console.WriteLine("Менше");
            counter++;
        }
    }
    else if (input < guessNumber)
    {
        Console.WriteLine("Більше");
        counter++;
    }
}
if (counter >= 7)
{
    Console.WriteLine("Ви програли");
}
int farms;
int duce;
int province;
Console.WriteLine("Enter farms");
while(!int.TryParse(Console.ReadLine(), out farms ))
{
    Console.WriteLine("not a number");
}

Console.WriteLine("Enter duces");
while (!int.TryParse(Console.ReadLine(), out duce))
{
    Console.WriteLine("not a number");
}
Console.WriteLine("Enter provinces");
while (!int.TryParse(Console.ReadLine(), out province))
{
    Console.WriteLine("not a number");

}

int result = farms * 1 + duce * 3 + province * 6;
Console.WriteLine("Total score is: " + result);
Console.ReadKey();


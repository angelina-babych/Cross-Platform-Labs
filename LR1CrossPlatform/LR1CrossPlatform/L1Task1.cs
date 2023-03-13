// See https://aka.ms/new-console-template for more information

int n;
int i = 0;
int sum = 0;

Console.Write("Enter the number of array elements:");
if (!Int32.TryParse(Console.ReadLine(), out n))
    n = 10;
Console.WriteLine($"Array will have {n} elements!");
int[] myArray = new int[n];
Console.WriteLine();

Random random = new Random();
for (i = 0; i < n; i++)
{
    myArray[i] = random.Next(-100, 100);
    Console.Write($"\t{myArray[i]}");
}
Console.WriteLine();

i = 0;
while (myArray[i] >= 0 && i < n)
{
    sum = sum + myArray[i];
    i++;
}
Console.Write($"\nSum from the first element to first negative is: {sum}\n");



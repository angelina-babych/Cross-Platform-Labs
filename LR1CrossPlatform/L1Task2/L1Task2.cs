// See https://aka.ms/new-console-template for more information

Console.Write("Enter the line of text:");
String? s = Console.ReadLine();
if (string.IsNullOrEmpty(s))
    s = "The Cat in the Hat is Not a Cat";
Console.WriteLine();
s = s.ToLower();
Console.WriteLine($"\t{s}");

for (int i = 0; i < s.Length; i++)
{

    if (s.IndexOf(s[i], s.IndexOf(s[i]) + 1) == -1)
    {
        Console.Write($"\nFirst non-repeating character is {s[i]}\n");

        break;
    }
}




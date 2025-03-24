int[] grades = new int[10];
int sum  = 0;
Console.WriteLine("podaj 10 liczb");

for (int i = 0; i < 10; i++)
{
    
    Console.Write($"liczba {i+ + 1} :");
    grades[i] = int.Parse( Console.ReadLine());
    sum += grades[i];
}
double average = (double)sum /grades.Length;

Console.WriteLine($"Suma:{sum} ");
Console.WriteLine($"srednia: {average}");

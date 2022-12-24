// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символа. 
// Первоначальный массив вводится с клавиатуры.

System.Console.WriteLine("Задайте длинну массива");
int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine();

string[] m1 = new string[n];
for (int i = 0; i < n; i++)
{
    System.Console.WriteLine($"Введите {i + 1} элемент массива: ");
    string element = Convert.ToString(System.Console.ReadLine());
    m1[i] = element;
}
string[] m2 = new string[m1.Length];

void Chetesli(string[] m1, string[] m2)
{
    int count = 0;
    for (int i = 0; i < m1.Length; i++)
    {
        if (m1[i].Length <= 3)
        {
            m2[count] = m1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

Chetesli(m1, m2);
System.Console.WriteLine("Заданному условию удовлетворяет массив:");
PrintArray(m2);

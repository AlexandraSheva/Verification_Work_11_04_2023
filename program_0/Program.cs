// Задача. Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.


void Print(string[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
    Console.WriteLine($"{arr[i]} ");
  Console.WriteLine();
}

string[] Words(string a, string b, string c, string d)
{
  string[] arr_1 = { a, b, c, d };

  return arr_1;
}

string[] Words_2(string[] arr_2)
{
  string[] arr_3 = new string [arr_2.Length];
  int i = 0;
  int i_2 = 0;
  while (i < arr_2.Length)
   i++;
  
  if (arr_2[i].Length <= 3)
    {
      arr_3[i_2] = arr_2[i];
      i_2++;
    }
  return arr_3;
}


string a_1 = Console.ReadLine();
string b_1 = Console.ReadLine();
string c_1 = Console.ReadLine();
string d_1 = Console.ReadLine();

string[] words = Words(a_1, b_1, c_1, d_1);
string[] words_2 = Words_2(words);
Print(words_2);



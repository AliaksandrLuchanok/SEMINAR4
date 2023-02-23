// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//МЕТОД конвертации типа double в тип int c ИГНОРИРОВАНИЕМ чисел после запятой

int NumberConvert (double numberDouble)
{
  int result = (int) numberDouble;
  return result;
}

  
//МЕТОД заполнения массива из 8 элементов удобным для пользователя способом, в том числе
// вещественными и отрицательными числами:
// 1. автоматически
//  1.1 рандомный диапазон значений
//  2.2 диапазон задает пользователь
// 2. пользователь сам вводит элементы в массив
// проверки на истинность вводимой позиции 1 или 2 для дальнейших действий
void FillArrayEightElement ()
{
  double [] fillArray = new double [8];
  Random rnd = new Random();
  Console.WriteLine("Choose a position: ");
  Console.WriteLine("1. Autocomplete array >>>> enter number 1");
  Console.WriteLine("2. Self entry >>>> enter number 2");
  int choisePosition = Convert.ToInt32(Console.ReadLine());
  if (choisePosition != 1 && choisePosition != 2)
  {
    Console.WriteLine("Error! Wrong choise of position: re-enter 1 or 2!");
    return;
  }
  if (choisePosition == 1)
  {
    Console.WriteLine("Choose a position: ");
    Console.WriteLine("1. Custom range >>>> enter number 1");
    Console.WriteLine("2. Set range >>>> enter number 2");
    int choiseAutoPosition = Convert.ToInt32(Console.ReadLine());
    if (choiseAutoPosition != 1 && choiseAutoPosition != 2)
    {
      Console.WriteLine("Error! Wrong choise of position: re-enter 1 or 2!");
      return;
    }
    if (choiseAutoPosition == 1)
    {
      for (int i = 0; i < 8; i++)
      {
        fillArray [i] = rnd.Next();
      }
    }
    if (choiseAutoPosition == 2)
    {
      Console.WriteLine("Enter the start number of the range:");
      double startNumber = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter end of range number:");
      double endNumber = Convert.ToDouble(Console.ReadLine());
      if (startNumber > endNumber)
      {
        Console.WriteLine("Error! The start number or range must be greater than the end number!");
        return;
      }
      for (int i = 0; i < 8; i++)
      {
        fillArray [i] = rnd.Next(NumberConvert(startNumber), NumberConvert(endNumber)+1);
      }
     }
  }
  if (choisePosition == 2)
  {
    for (int i = 0; i < 8; i++)
    {
      Console.WriteLine($"Enter your number for {i} cell:");
      fillArray [i] = Convert.ToDouble(Console.ReadLine());
    }
  }
  Console.WriteLine(string.Join("; ", fillArray));
}

//Точка входа в программу

FillArrayEightElement();

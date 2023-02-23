// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//МЕТОД, выводит в консоль задачу пользователю и возвращает из консоли введенное значение типа double
double PromtDouble (string message)
{
  Console.WriteLine(message);
  double result = Convert.ToDouble(Console.ReadLine());
  return result;
} 

//МЕТОД, выводит в консоль задачу пользователю и возвращает из консоли введенное значение типа int
int PromtInt (string message)
{
  Console.WriteLine(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
} 

//МЕТОД, проверяет входные данные (число и степень) на нули и, в соответствии со значениями и возвращает степень числа
double UserMathPow (double valueDouble, int valueInt)
{
  if (valueDouble == 0 && valueInt == 0)
  {
    Console.WriteLine ("Any number!!!");
    return -1;
  }
  if (valueDouble == 0 && valueInt != 0)
  {
    return 0;
  }
  if (valueDouble != 0 && valueInt == 0)
  {
    return 1;
  }
  double result = 1;
  for (int i = 0; i < valueInt; i++)
  {
     result *= valueDouble;
  }
  return result;
}

//Точка входа в основную программу
double numberBaseOfDegree = Math.Abs(PromtDouble("Enter number base of degree"));
int numberExponentiation  = Math.Abs(PromtInt("Enter natural degree"));
Console.WriteLine($"Natural degree {numberExponentiation} number {numberBaseOfDegree} is {Math.Round(UserMathPow (numberBaseOfDegree, numberExponentiation), 3)}");
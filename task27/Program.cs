// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Программа может принимать отрицательные и положительные целые и вещественные числа, но считает только целые числа

//МЕТОД, выводит в консоль задачу пользователю и возвращает из консоли введенное значение типа double
double PromtDouble (string message)
{
  Console.WriteLine(message);
  double result = Convert.ToDouble(Console.ReadLine());
  return result;
} 

//МЕТОД, проверяет входные данные (число) на отрицательный показатель, и в соответствии со
// значениями и совершает оперцию сложения элементов его разрядности

int UserMathPow (double valueSum)
{ 
  bool minusSing = false;
  if (valueSum > -1 && valueSum < 1)
  {
    return 0;
  }
  if (valueSum <= -1)
  {
    minusSing = true;
    valueSum = Math.Abs(valueSum);
  }
  int tempValue = Convert.ToInt32(Math.Round(valueSum, 1));
  string str = Convert.ToString(tempValue);
  int [] tempArr = new int [str.Length];
  int Sum = 0;
  for (int i = 0; i < str.Length; i++)
  {
    Sum += Convert.ToInt32(str[i].ToString());
  }
  if (minusSing)
  {
    Sum = -Sum;
  }
  return Sum;
}

//Точка входа в основную программу
double numberSum = PromtDouble("Enter your number, please");
Console.WriteLine($"Sum of elements your number {numberSum} is {UserMathPow(numberSum)}");
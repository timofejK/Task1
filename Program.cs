Console.WriteLine();
{
    double num1 = 0;
    double num2 = 0;
    string operation;
    bool exit;

 do
 {
   Console.WriteLine("Консольный калькулятор");
   Console.Write("Введите первое число: ");
   while (!double.TryParse(Console.ReadLine(), out num1))
   {
    Console.WriteLine("Ошибка: некорректный ввод. Пожалуйста, введите число.");
    Console.Write("Введите первое число: ");
   }

        
  Console.Write("Введите знак исчисления (+, -, *, /): ");
  operation = Console.ReadLine();

       
  Console.Write("Введите второе число: ");
  while (!double.TryParse(Console.ReadLine(), out num2))
  {
   Console.WriteLine("Ошибка: некорректный ввод. Пожалуйста, введите число.");
   Console.Write("Введите второе число: ");
  }

   double result = 0;

        
   switch (operation)
   {
     case "+":
      result = num1 + num2;
      break;
     case "-":
      result = num1 - num2;
      break;
     case "*":
      result = num1 * num2;
      break;
     case "/":
      if (num2 != 0)
      {
       result = num1 / num2;
      }
        else
        {
          Console.WriteLine("Ошибка: деление на ноль невозможно.");
          Console.ReadKey(); 
          exit = true;
          continue; 
        }
        break;
        default:
          Console.WriteLine("Ошибка: неверная операция.");
          Console.ReadKey();
          exit = true;
          continue; 
        }

        Console.WriteLine($"Результат: {result}");
        Console.WriteLine("Нажми любую клавишу для продолжения или введи 'x' для выхода.");
        if (Console.ReadLine().ToLower() == "x")
        {
         exit = true;
        }
        else
        {
          exit = false;
        }
    Console.Clear();
    } while (!exit);
}
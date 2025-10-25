Console.WriteLine();
{
    double num1 = 0;
    double num2 = 0;
    string operation;

    Console.WriteLine(" Консольный калькулятор ");
    Console.Write(" Введите первое число: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write(" Введите нужный знак исчисления (+, -, *, /): ");
    operation = Console.ReadLine();
    Console.Write(" Введите второе число: ");
    num2 = Convert.ToDouble(Console.ReadLine());
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
                return;
            }
            break;
        default:
            Console.WriteLine("Ошибка: неверная операция.");
            return;
    }
    Console.WriteLine($"Результат: {result}");
    Console.ReadKey();
}
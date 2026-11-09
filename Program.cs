using LAB07;


Function[] functions =
{
    new LinearFunction(2, 3, -5, 5),         
    new LinearFunction(1, 0, 0, 10),         
    new LinearFunction(0.5, -2, -10, 10),    
    new PowerFunction(1, 2, -5, 5),          
    new PowerFunction(1, 1, -10, 10),         
    new PowerFunction(2, 3, -2, 2),          
    new LogarithmicFunction(1, 0, 1, 10),    
    new LogarithmicFunction(2, 1, 1, 5),     
    new TrigonometricFunction(1, 0, -10, 10),
    new TrigonometricFunction(2, 1, 0, 5)   
};

double sumAt2 = 0;
int countAt2 = 0;

Console.WriteLine("Значения функций в точке x = 2: ");

foreach (Function f in functions)
{
    try
    {
        if (2 >= f.LowerBound && 2 <= f.UpperBound)
        {
            double val = f.Calculate(2);
            sumAt2 += val;
            countAt2++;
            Console.WriteLine($"{f.FunctionName}: {val:F4}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}

if (countAt2 > 0)
{
    Console.WriteLine($"Среднее значение в точке x=2: {sumAt2 / countAt2:F4}");
}
else
{
    Console.WriteLine("Ни одна функция не определена в точке x=2.");
}

double maxVal = double.MinValue;
Function maxFunc = null;

foreach (Function f in functions)
{
    if (1 >= f.LowerBound && 1 <= f.UpperBound)
    {
        double val = f.Calculate(1);

        if (val > maxVal)
        {
            maxVal = val;
            maxFunc = f;
        }
    }
}

Console.WriteLine("Функция с максимальным значением в точке x = 1: ");

if (maxFunc != null)
{
    Console.WriteLine($"Функция: {maxFunc.FunctionName}");
    Console.WriteLine($"Значение: {maxVal:F4}");
    
    Console.WriteLine($"Представление: {maxFunc}");
}
else
{
    Console.WriteLine("Нет функций, определённых в точке x=1.");
}


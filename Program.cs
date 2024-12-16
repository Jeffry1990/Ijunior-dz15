namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int firstNumber = 10;
            int secondNumber = 25;
            int minNumberFound = 50;
            int maxNumberFound = 150;

            Console.Write($"Введите число от {firstNumber} до {secondNumber}: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber >= firstNumber && inputNumber <= secondNumber)
            {
                for (int i = inputNumber; i <= maxNumberFound; i += inputNumber)
                {
                    if (i < minNumberFound)
                    {
                        continue;
                    }

                    Console.WriteLine(i);
                }

                Console.WriteLine($"Числа от {minNumberFound} до {maxNumberFound} которые крытны {inputNumber}");
            }
            else
            {
                Console.WriteLine("Неверный диапазон чисел");
            }
        }
    }
}

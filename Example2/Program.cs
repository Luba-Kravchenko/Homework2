/* Напишите программу, которая выводит третью цифру 
   заданного числа или сообщает, что третьей цифры нет.*/

  class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите трёхзначное число или 'q' для выхода");
            string num = Console.ReadLine();
            if (num == "q")
            {
                break;
            }
            if (num.Length == 3)
            { Console.WriteLine("Третья цифра числа: " + num[2]); }
            else if (num.Length <3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else
            {
                Console.WriteLine("Вы ввели не трёхзначное число");
            }
        }

    }
}

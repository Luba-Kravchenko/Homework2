/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным. */

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите цифру от 1 до 7, обозначеющую день недели или 'q' для выхода из программы");
            string s = Console.ReadLine();
            if (s == "q")
            {
                break;
            }

            int a = Convert.ToInt32(s);
            if (a > 0 && a < 6)
            {
                Console.WriteLine("Не выходной день");
            }
            else if (a == 6 || a == 7)
            {
                Console.WriteLine("Выходной день");

            }
            else
            {
                Console.WriteLine("Не является днём недели");
            }
        }
    }
}



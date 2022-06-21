using System;

namespace task1
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler uniqueInstance;
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public static ChocolateBoiler getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }
        public void fill()
        {
            if (isEmpty())
            {               
                empty = false;
                boiled = false;
                Console.Write("Заполняем нагреватель молочно-шоколадной смесью: ");
            }
        }
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                empty = true;
                boiled = false;
                Console.Write("Сливаем нагретое молоко и шоколад: ");
            }
        }
        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                boiled = true;
                Console.Write("Доводим содержимое до кипения: ");
            }
        }
        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
        public void Conclusion()
        {
            Console.WriteLine($"Пустой-{empty}, закипел-{boiled}");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.getInstance();
            chocolateBoiler.Conclusion();
            chocolateBoiler.fill();
            chocolateBoiler.Conclusion();
            chocolateBoiler.boil();
            chocolateBoiler.Conclusion();
            chocolateBoiler.drain();
            chocolateBoiler.Conclusion();
        }
    }
}

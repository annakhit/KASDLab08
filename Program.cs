using System;

namespace KASDLab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(4);
            stack.Push(-1);
            Console.WriteLine("Вывод стека:");
            stack.Print();

            Console.WriteLine($"Глубина элемента 4: {stack.Search(4)}");

            Console.WriteLine("Например, удалили элемент с верхушки");
            stack.Pop();
            stack.Print();
            Console.WriteLine("Является ли стек пустым?");
            Console.WriteLine(stack.Empty());
            Console.ReadKey();
        }
    }
}

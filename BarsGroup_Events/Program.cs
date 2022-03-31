using System;

namespace BarsGroup_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();

            foo.OnKeyPressed += Foo_OnKeyPressed;
            Console.WriteLine("Для завершения программы нажмите C");
            Console.WriteLine("Введите символ");
            foo.Run();


        }

        private static void Foo_OnKeyPressed(Object sender, char ski)
        {      
            Console.WriteLine( $"{ski}");
        }
    }


    class Foo
    {
        public event EventHandler<char>? OnKeyPressed;

        ConsoleKeyInfo a;

        public void Run()
        {
            while(Console.ReadKey().Key != ConsoleKey.C)
            {
               
                a = Console.ReadKey();
                char ski = a.KeyChar;

                OnKeyPressed?.Invoke(this, ski);
            }
            
        }
    }
}

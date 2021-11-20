using System;

namespace Stack
{
    class Program
    {
        private void Push(object obj)
        {
            //push
        }

        private object Pop()
        {
            object obj = new object();
            return obj;
        }

        private void Clear()
        {
            // clear
        }

        private void checkInput(string input)
        {
            object obj;
            switch (input)
            {
                case "pop":
                    Pop();
                    break;
                case "Pop":
                    Pop();
                    break;
                case "o":
                    Pop();
                    break;
                case "O":
                    Pop();
                    break;
                case "U":
                    obj = Console.ReadLine();
                    Push(obj);
                    break;
                case "u":
                    obj = Console.ReadLine();
                    Push(obj);
                    break;
                case "push":
                    obj = Console.ReadLine();
                    Push(obj);
                    break;
                case "Push":
                    obj = Console.ReadLine();
                    Push(obj);
                    break;
                case "Clear":
                    Clear();
                    break;
                case "clear":
                    Clear();
                    break;
                case "c":
                    Clear();
                    break;
                case "C":
                    Clear();
                    break;
                default:
                    retryInput();
                    break;
            }
        }

        private void retryInput()
        {
            Console.WriteLine("It's Pop, push or clear, buddy...");
            String input = Console.ReadLine();
            checkInput(input);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello there! What would you like to do? Your options are P(o)p, P(u)sh and (C)lear.");
            String input = Console.ReadLine();
            p.checkInput(input);


        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        private List<object> stack = new List<object>();

        private void Push(object obj)
        {
            stack.Add(obj);
            Continue();
        }

        private object Pop()
        {
            object obj = stack.First();
            stack.RemoveRange(0, 1);
            return obj;
        }

        private Boolean canPop()
        {
            return stack.Count != 0;
        }

        private void Clear()
        {
            stack.Clear();
            Continue();
        }

        private void Continue()
        {
            Console.WriteLine("What else do you want to do?");
            string input = Console.ReadLine();
            checkInput(input);
        }

        private void AlertStackIsEmpty()
        {
            Console.WriteLine("The stack is empty.");
            Continue();
        }

        private void checkInput(string input)
        {
            object obj;
            switch (input)
            {
                case "pop":
                    if (canPop()) { Console.WriteLine(Pop()); } else { AlertStackIsEmpty(); }
                    Continue();
                    break;
                case "Pop":
                    if (canPop()) { Console.WriteLine(Pop()); } else { AlertStackIsEmpty(); }
                    Continue();
                    break;
                case "o":
                    if (canPop()) { Console.WriteLine(Pop()); } else { AlertStackIsEmpty(); }
                    Continue();
                    break;
                case "O":
                    if (canPop()) { Console.WriteLine(Pop()); } else {AlertStackIsEmpty();}
                    Continue();
                    break;
                case "U":
                    Console.WriteLine("What do you want to push?");
                    obj = Console.ReadLine();
                    Push(obj);
                    break;
                case "u":
                    Console.WriteLine("What do you want to push?");
                    obj = Console.ReadLine();
                    Push(obj);
                    break;
                case "push":
                    Console.WriteLine("What do you want to push?");
                    obj = Console.ReadLine();
                    Push(obj);
                    break;
                case "Push":
                    Console.WriteLine("What do you want to push?");
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
                case "e":
                    Exit();
                    break;
                case "E":
                    Exit();
                    break;
                case "exit":
                    Exit();
                    break;
                case "Exit":
                    Exit();
                    break;
                default:
                    retryInput();
                    break;
            }
        }

        private void retryInput()
        {
            Console.WriteLine("It's pop, push, clear or exit.");
            String input = Console.ReadLine();
            checkInput(input);
        }

        private void Exit()
        {
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello there! What would you like to do? Your options are P(o)p, P(u)sh and (C)lear. You can also (E)xit.");
            String input = Console.ReadLine();
            p.checkInput(input);
        }
    }
}

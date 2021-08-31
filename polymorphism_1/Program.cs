using System;

namespace polymorphism_1
{
    public class addition
    {
        public void add()
        {
            int a = 30;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }

        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("\n"+c);
        }
        public void add(string a, string b)
        {
            string c =a+" "+b ;
            Console.WriteLine("\n"+c);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

                addition a = new addition();
                a.add();
                a.add("hii","hello");
               a.add(9, 9);
            }
        }
    }


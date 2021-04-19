using System;

namespace ConsoleApp2
{
    class test
    {
        public int j;
        public int k;
        public static int i = 0;
        public const int t = 50;

        public test(int j,int k)
        {
            this.j = j;
            this.k = k;
            i++;
        }
        public void display()
        {
            Console.WriteLine("New Copy Values = " + j + "," + k);
            Console.WriteLine("Same Copy Values = " + i);
            Console.WriteLine("Const Values = " + t);
        }

    }
    class Program
    {
        
        public static void Main(string[] args)
        {

            test t1 = new test(1, 12);
            t1.display();
            test.i = 20;
           // test.t = 30;
            test t2 = new test(2, 22);
            t2.display();
            test t3 = new test(3, 50);
            t3.display();
            test t4 = new test(4, 80);
            t3.display();
            if (t4.j == 4)
            {
                Console.WriteLine("OBJECT 4");
            }

        }
    }
}

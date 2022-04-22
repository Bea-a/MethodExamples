using System;

namespace method
{
    class Program
    {
        static void print()
        {
            Console.WriteLine("Welcome my ascendant");
        }

        static void circumference(int r)
        {
            Console.WriteLine("circumference: " + 2*(22/7)*r);
        }
        static int product()
        {
            int x=7, y=22,res;
            res=x*y;
            return res;
        }
        static int factorial(int n)
        {
            int f1=1;
            for(int i=1;i<=n;i++)
            {
                f1=f1*i;
            }
            return f1;
        }


        static void Main(string[] args)
        {
           int rad=7,n=4,getres;
           print();
           circumference(rad);
           getres=product();
           Console.WriteLine(getres);
           getres=factorial(n);
           Console.WriteLine(getres);
        }
    }
}

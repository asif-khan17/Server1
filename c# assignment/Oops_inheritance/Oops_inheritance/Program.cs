using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inheritence_Problem
{


    class A : B
    {

        internal int callA = 0;
        internal void func(D obj, int flag_2, int flag_3, int flag_5)
        {
            for (int i = 0; i < flag_2; i++)
            {
                obj.val = obj.val * 2;
                callA++;


            }

            base.func(obj, flag_3, flag_5);


        }


    }

    class B : C
    {
        public int callB = 0;

        internal void func(D obj2, int flag_3, int flag_5)
        {
            for (int i = 0; i < flag_3; i++)
            {
                obj2.val = obj2.val * 3;
                callB++;


            }

            base.func(obj2, flag_5);

        }

    }

    class C
    {
        public int callC = 0;
        internal void func(D obj3, int flag_5)
        {

            for (int i = 0; i < flag_5; i++)
            {
                obj3.val = obj3.val * 5;
                callC++;

            }

        }


    }

    class D : A
    {

        internal int val;
        int flag_2 = 0, flag_3 = 0, flag_5 = 0, k;
        public D()
        {

            val = 1;
        }
        public void update_val(int new_val)
        {
            int n = new_val;
            while (true)
            {
                if (n % 2 != 0)
                    break;

                flag_2++;
                n = n / 2;
            }

            while (true)
            {
                if (n % 3 != 0)
                    break;

                flag_3++;
                n = n / 3;
            }

            while (true)
            {
                if (n % 5 != 0)
                    break;

                flag_5++;
                n = n / 5;
            }

            func(this, flag_2, flag_3, flag_5);


            Console.WriteLine(val);
            Console.WriteLine("A is called " + callA + "  times");
            Console.WriteLine("B is called " + callB + "  times");
            Console.WriteLine("C is called " + callC + "  times");


        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            D d = new D();
            Console.WriteLine("Enter the value having factors 2 ,3 and 5");
            int new_val = Convert.ToInt32(Console.ReadLine());
            d.update_val(new_val);
            Console.ReadLine();


        }
    }
}

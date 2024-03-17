//static example
using System.Reflection.Metadata.Ecma335;

namespace CAStatic
{
    class log1
    {
        //non-static 
        public int multiplication(int x, int y)
        { 
        int res = x * y;
        return res;
        }
        //static 
        public static double division(int x , int y)
        {
            return x / y;

        }
        static void Main(string[] args)
        {
            log1 obj=new log1();
            int res = obj.multiplication(10, 5);
            Console.WriteLine("the result is"+res);
            int res1= Convert.ToInt32(log1.division(10, 5));
            Console.WriteLine("The result is "+res1 );

        }

    }
}


namespace CAStatic
{
    class Sample
    {
        int x;
        static int y;
        public Sample()
        {
            x = 10;
        }
        static Sample()
        {
            y = 10;
        }

        public void Display()
        {
            Console.WriteLine("The value of x is "+x);
            x++;
            Console.WriteLine("The value of y is"+y);
            y++;
        }
    }
     class log2
     {
         static void Main(string[] args)

         {
            Logger.Log("Sample Class Execution Starts");
            Sample obj = new Sample();
            obj.Display();
            Sample obj1 = new Sample();
            obj1.Display();
            Sample obj2 = new Sample();
            obj2.Display();
            Logger.Log("Sample class Execution Ends");



        }
        static log2()
        {
            Console.WriteLine("Static Constructor");
        }


     }
}

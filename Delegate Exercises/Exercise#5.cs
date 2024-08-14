
namespace Delegate_Exercises
{
    public delegate void ExampleDelegate(string xyz);
    public class Exercise_5
    {
        public  void Method1(string xyz)
        {
            Console.WriteLine(xyz + " Method1");
        }

        public  void Method2(string xyz)
        {
            Console.WriteLine(xyz + " Method2");
        }
        public void UseDelegate()
        {
            ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate, ex4Delegate;

            ex1Delegate = new ExampleDelegate(Method1);
            ex2Delegate = new ExampleDelegate(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            ex4Delegate = ex1Delegate - ex2Delegate;
            ex1Delegate("AAA");
            Console.WriteLine("==================");
            ex2Delegate("BBB");
            Console.WriteLine("==================");
            ex3Delegate("CCC");
            Console.WriteLine("==================");
            ex4Delegate("DDD");
            Console.WriteLine("==================");
            ex4Delegate = ex3Delegate - ex1Delegate;
            ex4Delegate("EEE");
            ex4Delegate = ex3Delegate - ex2Delegate;
            ex4Delegate("FFF");
            Console.ReadLine();
        }
    }
}

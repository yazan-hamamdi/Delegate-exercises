
namespace Delegate_Exercises
{
    public class Exercise__1
    {
        public delegate void MyDelegate();
        public void PrintHello ()
        {
            Console.WriteLine("Hello !!!");
            Console.ReadLine();
        }
        public void UseDelegate ()
        {
            //MyDelegate myDelegate = new MyDelegate(PrintHello);
            MyDelegate myDelegate = PrintHello;
            myDelegate();
        }
    }
}

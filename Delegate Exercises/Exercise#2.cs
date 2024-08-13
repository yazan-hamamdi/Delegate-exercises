
namespace Delegate_Exercises
{
    public class Exercise_2
    {
        public delegate int MyDelegate(int num);
        public int Square(int num)
        {
            return (num * num);
        }
        public int multiplyByTen(int num)
        {
            return (num * 10);
        }
        public void UseDelegate(int num)
        {
            MyDelegate myDelegate = new MyDelegate(Square);
            int result1 = myDelegate(num);
            Console.WriteLine(result1);
            myDelegate = new MyDelegate(multiplyByTen);
            int result2 = myDelegate(num);
            Console.WriteLine(result2);
        }
    }
}

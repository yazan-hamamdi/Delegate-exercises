

namespace Delegate_Exercises
{
    public class Exercise_3
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
        public void UseDelegateAsParameter(MyDelegate myDelegate)
        {
            Console.WriteLine(myDelegate(4));
        }
        public void UseDelegate()
        {
            MyDelegate myDelegate = Square;
            UseDelegateAsParameter(myDelegate);
            myDelegate = multiplyByTen;
            UseDelegateAsParameter(myDelegate);
        }

    }
}

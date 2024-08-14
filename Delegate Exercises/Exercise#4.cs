namespace Delegate_Exercises
{
    public class Exercise_4
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
            for (int i = 0; i <= 5;i++ )
            Console.WriteLine($"call num is {i}  {myDelegate(4)}  ");
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

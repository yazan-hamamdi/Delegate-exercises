
namespace Delegate_Exercises
{
    public class Exercise_6
    {
         delegate void MyDelegate(ref int intValue);
        void Method1(ref int intValue)
        {
            intValue = intValue + 5;
            System.Console.WriteLine("Method1 " + intValue);
        }
        public void Method3()
        {
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = new MyDelegate(Method1);
            MyDelegate myDelegate3 = myDelegate2 + myDelegate1;
            int intParameter = 5;
            myDelegate3(ref intParameter);
        }
    }
}

namespace _2._9dars.Api;

public class MyClass
{
    public void MySwap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

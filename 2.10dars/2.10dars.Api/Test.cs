namespace _2._10dars.Api;

public class Test
{
    List<string> _list = new List<string>();    
    public void Print<T>(Object obj)
    {
        var a = (T)obj;
    }

    public T CastObject<T>(object obj)
    {
        return (T)obj;
    }
}

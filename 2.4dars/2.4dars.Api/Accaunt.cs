namespace _2._4dars.Api;

public class Accaunt
{
    private string _name;

    private List<int> _scores;

    public List<int> Scores
    {
        get { return _scores; }
        set { _scores = value; }
    }



    private int _age;

    public int Age
    {
        get { return _age; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            _age = value; 
        }
    }




    public string Name
    {
        get { return _name; }
        set
        {
            if (value.StartsWith("A"))
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Error A bn boshlanmagan");
            }
        }
    }
}

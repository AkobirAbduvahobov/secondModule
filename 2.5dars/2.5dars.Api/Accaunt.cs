namespace _2._5dars.Api;

public class Accaunt
{

    private string _password;
    public string Password
    {
        get { return _password; }
        set 
        { 
            if (value.Length >= 8)
            {
                _password = value;
            }
        }
    }

    private double _balance = 0;

    public double Balance
    {
        get { return _balance; }
    }


    public void Deposit(double amount)
    {
        _balance += amount;
    }




    public int Age;

    private int _age;

    public int GetAge()
    {
        return _age;
    }
    public void SetAge(int age)
    {
        _age = age;
    }


    public string Name;
    public string Description;
}

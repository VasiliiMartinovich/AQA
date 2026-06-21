using System.Runtime.InteropServices.JavaScript;

namespace HW6_8.Task4;
/*Создать базовый класс Product с методами, позволяющим вывести на экран информацию
о товаре, а также определить, соответствует ли она сроку годности на текущую дату.*/
public abstract class Product()
{
    public string _name;
    public DateTime _productionDate;
    public DateTime _expirationDate;

    public Product(string name, DateTime productionDate, DateTime expirationDate)
    {
        _name = name;
        _productionDate = productionDate;
        _expirationDate = expirationDate;
    }
    
    DateTime today = DateTime.Today;
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Product information: {_name}");
    }

    public virtual void isExpired()
    {
        if (DateTime.Now > _expirationDate)
        {
            Console.WriteLine($"The {_name} is expired");
        }
        else
        {
            Console.WriteLine($"The {_name} is NOT expired");
        }
    }
}
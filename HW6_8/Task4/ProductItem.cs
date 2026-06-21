namespace HW6_8.Task4;
/*Продукт (название, цена, дата производства, срок годности) со своими методами вывода информации на экран,
    и определения соответствия сроку годности.*/
    
public class ProductItem : Product
{
    public string _name;
    public DateTime _productionDate;
    public DateTime _expirationDate;

    public ProductItem(string Name, DateTime productionDate, DateTime expirationDate) : base()
    {
        _name = Name;
        _productionDate = productionDate;
        _expirationDate = expirationDate;
    }
    
    public override void PrintInfo()
    {
        Console.WriteLine($"Product information: {_name},{_productionDate},{_expirationDate}");
    }

    public override void isExpired()
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
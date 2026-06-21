namespace HW6_8.Task4;
/*Партия (название, цена, количество шт, дата производства, срок годности) со своими методами вывода информации на экран,
    и определения соответствия сроку годности.*/

public class Batch : Product
{
    public string _batchName;
    public double _price;
    public int _quantity;
    public DateTime _productionDate;
    public DateTime _expirationDate;
    
    public Batch(string batchName, double price, int quantity, DateTime productionDate, DateTime expirationDate) : base()
        {
        _batchName = batchName;
        _price = price;
        _quantity = quantity;
        _productionDate = productionDate;
        _expirationDate = expirationDate;
        }
    
    public override void PrintInfo()
    {
        Console.WriteLine($"Product information: {_batchName},{_price},{_quantity}, {_productionDate},{_expirationDate}");
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
namespace HW6_8.Task4;
/*Комплект (названия, цена, перечень продуктов)*/
    
public class Set : Product

{
    public ProductItem[] Items;
    
    public string _setName;
    public double _setPrice;
    public string _productList;

    public Set(string setName, double setPrice, string productList) : base()
    {
        _setName = setName;
        _setPrice = setPrice;
        _productList = productList;
    }
}
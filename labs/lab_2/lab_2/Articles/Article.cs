class Article
{
    //Attributes / Properties
    public string Reference { get; set; }
    public string Name { get; set; }
    public double SalePrice { get; set; }

    //Constructors
    public Article(string reference, string name, double salePrice)
    {
        Reference = reference;
        Name = name;
        SalePrice = salePrice;
    }

    //ToString method
    public override string ToString()
    {
        return $"Reference: {Reference}, Name: {Name}, Sale Price: {SalePrice}";
    }
}
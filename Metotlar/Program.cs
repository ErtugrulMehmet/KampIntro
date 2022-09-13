using Metotlar;

Product product1 = new Product();
product1.Name = "Elma";
product1.Id = 2;
product1.Description = "Yeşil";
product1.Price = 15;

Product product2 = new Product() { Name="Armut",Price = 15,Id=2,Description="Mor"};

Product[] products = new Product[] { product1, product2 };

foreach (var item in products)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.Price);
    Console.WriteLine(item.Id);
}

Console.WriteLine("--------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);
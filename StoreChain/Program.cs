// See https://aka.ms/new-console-template for more information
using StoreChain;

Store store1 = new Store("as", "supermarket");
Console.WriteLine(store1.GetName());
foreach (var product in store1.products)
{
    
    Console.WriteLine(product.Name);
} 
Store store2 = new Store("iDEA", "supermarket");
Store store3 = new Store("aa", "corner shop");
Console.WriteLine(store3.GetName());
foreach (var product in store3.products)
{

    Console.WriteLine(product.Name);
}
Store Store4 = new Store("aa", "corner shop");
Store store5 = new Store("Heakth1", "pharmacy");
Console.WriteLine(store5.GetName());
foreach (var product in store5.products)
{

    Console.WriteLine(product.Name);
}
Store store = new Store("Haelath 2", "pharmacy");


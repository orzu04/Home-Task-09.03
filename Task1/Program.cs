


using Task1;
var cache= new  Cache<string>();
cache.Add("Orzu");
cache.Add("Ali");
System.Console.WriteLine();
cache.Add("Nuhammad");
cache.Remove("Nuhammad");
System.Console.WriteLine(cache.Get());
foreach (var item in cache.Get())
{
    
    System.Console.WriteLine(item);
}
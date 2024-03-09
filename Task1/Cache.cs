namespace Task1;

public class Cache<T>
{


public   List<T> Name= new List<T>();


public   List<T> Get()
{

   return Name;
}


public   void Add(T name)
{

   Name.Add(name);

}

public   void Remove(T name)
{

    Name.Remove(name);

}


}

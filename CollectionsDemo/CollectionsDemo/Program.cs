namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionsDemo.CollectionClass collection = new CollectionsDemo.CollectionClass();
            collection.doListDemo();
            collection.doStackDemo();
            collection.doQueueDemo();
            collection.doSetDemo();
            collection.doDictionaryDemo();
        }        
    }
}
//FindAll(x => x.state.Equals(cityName))-UC8-UserRegistration, UC9-&&, UC10-Count
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
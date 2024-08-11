namespace TASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // var obj1 = User.ShowTable(); /*this is used if only User class was static*/
            //foreach(var member in ShowTable)
            //{
            //    Console.WriteLine(member);var obj2 
            //}
            var user = new User();
            var table = user.ShowTable();
            
            user.PrintTable(table);
            
                 
        }
    }
}

using ViewModel;
using _1ceGra4pe;
namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonTblDB cdb = new();
            PersonTblDB cList = cdb.SelectAll();
            foreach (PersonTblDB c in cList)
                Console.WriteLine(c.Name);

        }
    }
}

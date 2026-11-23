using Service;
using _1ceGra4pe;
using _1cegr4apeAPI;
namespace TestAPI

{
    public class Program
    {
        static async Task  Main(string[] args)
        {
            APIService service = new APIService();
            PersonTblList x= await service.GetAllPersons();
            Console.WriteLine(x.Count);

        }
    }
}

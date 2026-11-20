using _1ceGra4pe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class APIService: _1ceGra4peAPI
    {
        string uri;
        public HttpClient client;
        public APIService()
        {
            uri = "http://localhost:5115";
            client = new HttpClient();
        }
        public async Task<PersonTblList> GetAllPersons()
        {
            return await client.GetFromJsonAsync<PersonTblList>(uri + "/api/Insert/personSelector");

        }
        public async Task<int> DeleteAPerson(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeletePerson/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAPerson(PersonTbl c)
        {
            return (await client.PutAsJsonAsync<PersonTbl>(uri + "/api/Insert/UpdatePerson/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPerson(PersonTbl c)
        {
            return (await client.PostAsJsonAsync<PersonTbl>(uri + "/api/Insert/InsertPerson/" , c)).IsSuccessStatusCode ? 1 : 0;
        }

    }
}

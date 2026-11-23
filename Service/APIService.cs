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
            uri = "http://localhost:5125";
            client = new HttpClient();
        }
        public async Task<PersonTblList> GetAllPersons()
        {
            return await client.GetFromJsonAsync<PersonTblList>(uri + "/api/selectapi/SelectAllPersons");

        }
        public async Task<int> DeleteAPerson(int id)
        {
            return (await client.DeleteAsync(uri + "/api/selectapi/DeleteAPerson" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAPerson(PersonTbl c)
        {
            return (await client.PutAsJsonAsync<PersonTbl>(uri + "/api/selectapi/UpdateAPerson", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPerson(PersonTbl c)
        {
            return (await client.PostAsJsonAsync<PersonTbl>(uri + "/api/selectapi/InsertAPerson", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ArtistTblList> GetAllArtists()
        {
            return await client.GetFromJsonAsync<ArtistTblList>(
                uri + "/api/selectapi/SelectAllArtists");
        }

        public async Task<int> DeleteAnArtist(int id)
        {
            return (await client.DeleteAsync(
                uri + "/api/selectapi/DeleteAnArtist/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAnArtist(ArtistTbl a)
        {
            return (await client.PutAsJsonAsync<ArtistTbl>(
                uri + "/api/selectapi/UpdateAnArtist", a)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnArtist(ArtistTbl a)
        {
            return (await client.PostAsJsonAsync<ArtistTbl>(
                uri + "/api/selectapi/InsertAnArtist", a)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<GenreTblList> GetAllGenres()
        {
            return await client.GetFromJsonAsync<GenreTblList>(
                uri + "/api/selectapi/SelectAllGenres");
        }

        public async Task<int> DeleteAGenre(int id)
        {
            return (await client.DeleteAsync(
                uri + "/api/selectapi/DeleteAGenre/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAGenre(GenreTbl g)
        {
            return (await client.PutAsJsonAsync<GenreTbl>(
                uri + "/api/selectapi/UpdateAGenre", g)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAGenre(GenreTbl g)
        {
            return (await client.PostAsJsonAsync<GenreTbl>(
                uri + "/api/selectapi/InsertAGenre", g)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<SongTblList> GetAllSongs()
        {
            return await client.GetFromJsonAsync<SongTblList>(
                uri + "/api/selectapi/SelectAllSongs");
        }

        public async Task<int> DeleteASong(int id)
        {
            return (await client.DeleteAsync(
                uri + "/api/selectapi/DeleteASong/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateASong(SongTbl s)
        {
            return (await client.PutAsJsonAsync<SongTbl>(
                uri + "/api/selectapi/UpdateASong", s)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertASong(SongTbl s)
        {
            return (await client.PostAsJsonAsync<SongTbl>(
                uri + "/api/selectapi/InsertASong", s)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<SongLineTblList> GetAllSongLines()
        {
            return await client.GetFromJsonAsync<SongLineTblList>(
                uri + "/api/selectapi/SelectAllSongLines");
        }

        public async Task<int> DeleteASongLine(int id)
        {
            return (await client.DeleteAsync(
                uri + "/api/selectapi/DeleteASongLine/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateASongLine(SongLineTbl s)
        {
            return (await client.PutAsJsonAsync<SongLineTbl>(
                uri + "/api/selectapi/UpdateASongLine", s)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertASongLine(SongLineTbl s)
        {
            return (await client.PostAsJsonAsync<SongLineTbl>(
                uri + "/api/selectapi/InsertASongLine", s)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ChordEventTblList> GetAllChordEvents()
        {
            return await client.GetFromJsonAsync<ChordEventTblList>(
                uri + "/api/selectapi/SelectAllChordEvents");
        }

        public async Task<int> DeleteAChordEvent(int id)
        {
            return (await client.DeleteAsync(
                uri + "/api/selectapi/DeleteAChordEvent/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAChordEvent(ChordEventTbl c)
        {
            return (await client.PutAsJsonAsync<ChordEventTbl>(
                uri + "/api/selectapi/UpdateAChordEvent", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAChordEvent(ChordEventTbl c)
        {
            return (await client.PostAsJsonAsync<ChordEventTbl>(
                uri + "/api/selectapi/InsertAChordEvent", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<AdminTblList> GetAllAdmins()
        {
            return await client.GetFromJsonAsync<AdminTblList>(
                uri + "/api/selectapi/SelectAllAdmins");
        }




    }
}

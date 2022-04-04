using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDatabaseZero.Models;
using Newtonsoft.Json;
using System.IO;

namespace WebApplicationDatabaseZero.Data
{
    public class ArtistRepositoryJson : IArtistRepository
    {
        private string dataSourceString = @"Data/Source/artists.json";
        public List<Artist> GetArtists()
        {
            JsonSerializer mySerializer = new JsonSerializer();
            StreamReader myStreamreder = File.OpenText(dataSourceString);
            List<Artist> myList = (List<Artist>) mySerializer.Deserialize(myStreamreder,typeof(List<Artist>));
            myStreamreder.Close();
            return myList;

        }
    }
}

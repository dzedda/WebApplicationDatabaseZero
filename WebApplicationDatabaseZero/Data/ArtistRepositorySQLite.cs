using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDatabaseZero.Models;
using Microsoft.Data.Sqlite;

namespace WebApplicationDatabaseZero.Data
{
    public class ArtistRepositorySQLite : IArtistRepository
    {
        private string dataSourceString = @"Data Source=Data/Source/chinook.db";
        public List<Artist> GetArtists()
        {
            
            SqliteConnection myConnection = new SqliteConnection(dataSourceString);
            SqliteCommand myCommand = new SqliteCommand("SELECT * FROM tblArtists");

            List<Artist> listaArtisti = new List<Artist>();
            SqliteDataReader myDatareader;
            myCommand.Connection = myConnection;

            myConnection.Open();
            myDatareader = myCommand.ExecuteReader();
            while (myDatareader.Read())
            {
                Artist existentArtist = new Artist();
                int id = Convert.ToInt32(myDatareader["idArtist"]);
                string nome = Convert.ToString(myDatareader["Name"]);
                existentArtist.IdArtist = id;
                existentArtist.Name = nome;
                listaArtisti.Add(existentArtist);
            }
            myConnection.Close();
            return listaArtisti;           
        }
    }
}

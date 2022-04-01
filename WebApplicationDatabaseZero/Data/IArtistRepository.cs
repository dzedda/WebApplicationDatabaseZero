using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDatabaseZero.Models;

namespace WebApplicationDatabaseZero.Data
{
    interface IArtistRepository
    {
        List<Artist> GetArtists();
    }
}

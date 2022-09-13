using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProofilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Realtionship

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

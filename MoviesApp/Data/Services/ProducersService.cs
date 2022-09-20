using MoviesApp.Data.Base;
using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducerService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}

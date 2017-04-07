using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository( AppDbContext appContext)
        {
            _appDbContext = appContext;
        }

        public IEnumerable<Pie> Pies
        {
            get

            {
                return _appDbContext.Pies.Include(c=>c.Category);
            }
                 
        }

        IEnumerable<Pie> IPieRepository.PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pies.Include(c=>c.Category).Where( p=> p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}

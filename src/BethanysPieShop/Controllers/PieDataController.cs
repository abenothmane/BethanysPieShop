using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    [Route("api/[controller]")]
    public class PieDataController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieDataController(IPieRepository pieRepository )
        {
            _pieRepository = pieRepository;
        }


        [HttpGet]
        public IEnumerable<PieViewModel> LoadMorePies()
        {
            IEnumerable<Pie> dbPies = dbPies = _pieRepository.Pies.OrderBy(p => p.PieId).Take(10);

            List<PieViewModel> pies = new List<PieViewModel>();

            foreach (var dbpie in dbPies)
            {
                pies.Add(MapDbPieToPieViewModel(dbpie));
            }

            return pies;

        }

        public PieViewModel MapDbPieToPieViewModel(Pie pie)
        {
            return new PieViewModel() {

                PieId = pie.PieId,
                Name = pie.Name,
                Price = pie.Price,
                ShortDescription = pie.ShortDescription,
                ImageThumbnailUrl = pie.ImageThumbnailUrl
            };
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private  readonly ICategoryRepository _categoryRepository;
        private  readonly IPieRepository _pieRepository;


        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }



        public IActionResult List(string category)
        {

            IEnumerable<Pie> pies;
            string currentCategory = string.Empty;


            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.Pies.OrderBy(p => p.PieId);
                currentCategory = "All Pies";
            }

            else
            {
                pies = _pieRepository.Pies.Where(p => p.Category.CategoryName == category).OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }


           
            return View(new PiesListViewModel {Pies = pies, CurrentCategory = currentCategory });
        }


        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie==null)
            {
                return NotFound();
            }

            return View(pie);
            
        }
    }
}

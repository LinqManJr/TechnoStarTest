using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Dto;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IRepository<BookResult> _repository;

        public BookController(IRepository<BookResult> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _repository.GetAllAsync();
            return View(books);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteRowAsync(id);
            return View(await _repository.GetAllAsync());
        }

        public async Task<IActionResult> Update(int id)
        {
            var model = await _repository.GetAsync(id);
            return View("Edit", model);
        }

        public async Task<IActionResult> Save(BookResult bookResult)
        {
            await _repository.UpdateAsync(bookResult);
            return View("Index");
        }

        public async Task<IActionResult> OrderBy(int id)
        {
            var results = await _repository.GetAllAsync();
            switch (id)
            {
                case 1: { results = results.OrderBy(x => x.Title);break; }
                case 2: { results = results.OrderBy(x => x.Name); break; }
                case 3: { results = results.OrderBy(x => x.Date); break; }
            }
            return View("Index", results);
        }
    }
}
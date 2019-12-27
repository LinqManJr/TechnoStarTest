using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IRepository<AuthorResult> _repository;

        public AuthorController(IRepository<AuthorResult> repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var authors = await _repository.GetAllAsync();
            return View(authors);
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

        public async Task<IActionResult> Save(AuthorResult authorResult)
        {
            await _repository.UpdateAsync(authorResult);
            return View("Index");
        }

        public async Task<IActionResult> OrderBy(int id)
        {
            var results = await _repository.GetAllAsync();
            switch (id)
            {
                case 1: { results = results.OrderBy(x => x.Name); break; }
                case 2: { results = results.OrderBy(x => x.Surname); break; }                
            }
            return View("Index", results);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotesApp.Controllers
{
    public class NotesController : Controller
    {
        private INoteRepository _repository;
        public NotesController(INoteRepository repository)
        {
            _repository = repository;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<Note> allNotes = _repository.DisplayAllNotes().ToList();
            return View(allNotes);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Note note)
        {
            if(ModelState.IsValid)
            {
                _repository.AddNewNote(note);
                return RedirectToAction("index");
            }

            return View();
        }


    }
}


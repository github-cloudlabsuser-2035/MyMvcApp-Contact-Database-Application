using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>();

        // GET: /User/
        public IActionResult Index()
        {
            return View(users);
        }

        // GET: /User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: /User/Edit/5
        public IActionResult Edit(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: /User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var existingUser = users.Find(u => u.Id == id);
                if (existingUser == null)
                {
                    return NotFound();
                }

                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: /User/Delete/5
        public IActionResult Delete(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: /User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            users.Remove(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
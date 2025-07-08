using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TheTower.Data;
using TheTower.Models;

namespace TheTower.Controllers
{
    public class MonstersController : Controller
    {
        private readonly TowerContext _context;
        private readonly TowerRepo _repo;

        public MonstersController(TowerContext context, TowerRepo repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: Monsters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Monster
    .OrderBy(m => m.RollNumber == null ? int.MaxValue : m.RollNumber)
    .ThenBy(m => m.ChallengeRating == null ? double.MaxValue : m.ChallengeRating)
    .ToListAsync());
            //return View(await _context.Monster.OrderBy(m => m.RollNumber).OrderBy(m => m.ChallengeRating).ToListAsync());
        }

        // GET: Monsters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster
                .FirstOrDefaultAsync(m => m.ID == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // GET: Monsters/Create
        public async Task<IActionResult> Create()
        {
            List<Monster> monsterList = await _repo.GetMonsterList();
            var viewModel = new MonsterCreateViewModel
            {
                Monster = new Monster(),
                MonsterList = monsterList
            };

            return View(viewModel);
        }

        // POST: Monsters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ChallengeRating,Name,Source,RollNumber,ImagePath")] Monster monster)
        {
            if (ModelState.IsValid)
            {
                monster.ImagePath = monster.Name + ".jpg";
                _context.Add(monster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monster);
        }

        [HttpGet]
        public async Task<Monster> GetMonsterDetails(string index)
        {
            return await _repo.GetMonsterByIndex(index);
        }

        // GET: Monsters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster.FindAsync(id);
            if (monster == null)
            {
                return NotFound();
            }
            return View(monster);
        }

        // POST: Monsters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ChallengeRating,Name,Source,RollNumber,ImagePath")] Monster monster)
        {
            if (id != monster.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonsterExists(monster.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(monster);
        }

        // GET: Monsters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster
                .FirstOrDefaultAsync(m => m.ID == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // POST: Monsters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monster = await _context.Monster.FindAsync(id);
            _context.Monster.Remove(monster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonsterExists(int id)
        {
            return _context.Monster.Any(e => e.ID == id);
        }
    }
}

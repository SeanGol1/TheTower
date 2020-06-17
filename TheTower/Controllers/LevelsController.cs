using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheTower.Data;
using TheTower.Models;

namespace TheTower.Controllers
{
    public class LevelsController : Controller
    {
        private readonly TowerContext _context;
        private readonly TowerRepo _repo;

        public LevelsController(TowerContext context,TowerRepo repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: Levels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Level.ToListAsync());
        }

        // GET: Levels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var level = await _context.Level
                .FirstOrDefaultAsync(m => m.ID == id);
            if (level == null)
            {
                return NotFound();
            }

            return View(level);
        }

        // GET: Levels/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Levels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,RoomLevel,EventID,Name,SessionID,BiomeID,CRLevel,MonsterID,CurrentRoom")] Level level)
        {
            if (ModelState.IsValid)
            {
                level.SessionID = 1;
                level.CRLevel = _repo.GetCRLevel(level.SessionID, level.CRLevel);
                level.MonsterID = _repo.GetMonsterIDbyRoll(level.MonsterID, level.CRLevel);
                level.Name = _repo.GetMonsterName(level.MonsterID);

                int RoomMove = 0;

                switch (level.RoomLevel)
                {
                    case 1:
                        RoomMove = -6;
                        break;
                    case 2:
                        RoomMove = -5;
                        break;
                    case 3:
                        RoomMove = -4;
                        break;
                    case 4:
                        RoomMove = -3;
                        break;
                    case 5:
                        RoomMove = -2;
                        break;
                    case 6:
                        RoomMove = -1;
                        break;
                    case 7:
                        RoomMove = 1;
                        break;
                    case 8:
                        RoomMove = 2;
                        break;
                    case 9:
                        RoomMove = 3;
                        break;
                    case 10:
                        RoomMove = 4;
                        break;
                    case 11:
                        RoomMove = 5;
                        break;
                    case 12:
                        RoomMove = 6;
                        break;
                    default:
                        RoomMove = 0;
                        break;
                }

                //currentroom
                level.RoomLevel= 0 + RoomMove;

                        _context.Add(level);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(level);
        }

        // GET: Levels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var level = await _context.Level.FindAsync(id);
            if (level == null)
            {
                return NotFound();
            }
            return View(level);
        }

        // POST: Levels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,RoomLevel,EventID,Name,SessionID")] Level level)
        {
            if (id != level.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(level);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LevelExists(level.ID))
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
            return View(level);
        }

        // GET: Levels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var level = await _context.Level
                .FirstOrDefaultAsync(m => m.ID == id);
            if (level == null)
            {
                return NotFound();
            }

            return View(level);
        }

        // POST: Levels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var level = await _context.Level.FindAsync(id);
            _context.Level.Remove(level);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LevelExists(int id)
        {
            return _context.Level.Any(e => e.ID == id);
        }
    }
}

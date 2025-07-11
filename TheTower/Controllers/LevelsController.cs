﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheTower.Data;
using TheTower.Models;
using System.Net;

namespace TheTower.Controllers
{
    public class LevelsController : Controller
    {
        // Link DB Context and Repository
        private readonly TowerContext _context;
        private readonly TowerRepo _repo;

        public LevelsController(TowerContext context, TowerRepo repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: Levels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Level.ToListAsync());
        }

        //
        // Levels/Create Ajax Calls
        // Get Info From JQuery Ajax Call and then load a partial page inside the current page to display results.
        //

        //After the Gen button is clicked for Room Roll, find out what room will be next given the dice roll number.
        public ActionResult GetNewLevel(int roll, int curRoom, int sessionid)
        {

            List<RoomRoll> model = null;

            var query = from r in _context.RoomRoll
                        where r.DiceRoll == roll
                        select r;
            model = query.ToList();
            Level levelexist = null;
            foreach (var item in model)
            {
                var query2 = from l in _context.Level
                             where l.SessionID == sessionid
                             where l.RoomLevel == (curRoom + item.RoomMove)
                             select l;
                levelexist = query2.FirstOrDefault();
            }
            if (levelexist == null)
            {
                ViewBag.LevelExist = false;
            }
            else
            {
                    ViewBag.LevelExist = true;
                ViewBag.Name = levelexist.Name;
                
            }


            ViewBag.CRoomLevel = curRoom;
            return PartialView("RoomNumberPartialView", model);
        }
        //After the Gen button is clicked for Biome, find out what Biome will be next given the dice roll number.
        public ActionResult GetNewBiome(int roll)
        {
            List<Biome> model = null;

            var query = from b in _context.Biome
                        where b.RollNumber == roll
                        select b;
            model = query.ToList();

            return PartialView("BiomeItemView", model);
        }
        //After the ViewList button is clicked on biome, display the list of biomes and relative roll numbers.
        public ActionResult GetBiomeList()
        {
            List<Biome> model = null;

            var query = from b in _context.Biome
                        select b;
            model = query.ToList();

            return PartialView("_GetBiomeListView", model);
        }
        //After the Gen button is clicked on event, find out what Event will be next given the dice roll number.
        public ActionResult GetNewEvent(int roll)
        {
            List<Event> model = null;

            var query = from e in _context.Event
                        where e.RollNumber == roll
                        select e;
            model = query.ToList();

            return PartialView("_EventItemView", model);
        }
        //After the ViewList button is clicked on Event, display the list of Events and relative roll numbers.
        public ActionResult GetEventDetails(int? id)
        {
            Event model = null;

            var query = from e in _context.Event
                        where e.RollNumber == id
                        select e;
            model = query.FirstOrDefault();

            return PartialView("_GetEventView", model);
        }
        //After the ViewList button is clicked on Event, display the list of Events and relative roll numbers.
        public ActionResult GetEventList()
        {
            List<Event> model = null;

            var query = from e in _context.Event
                        select e;
            model = query.ToList();

            return PartialView("_GetEventListView", model);
        }
        //After the Gen button is clicked on CR Level, find out what Monster CR will be next given the dice roll number.
        public ActionResult GetNewCR(int roll , int sessionid)
        {
            CRRoll model = null;

            var query = from c in _context.CRRoll
                        where c.RollNumber == roll
                        where c.SessionId == sessionid
                        select c;
            model = query.FirstOrDefault();

            return PartialView("_CRItemList", model);
        }
        //After the ViewList button is clicked on CR List, display the list of Monster CR's and relative roll numbers.
        public ActionResult GetMonCRList(int sessionid)
        {
            List<CRRoll> model = null;

            var query = from m in _context.CRRoll
                        where m.SessionId == sessionid
                        orderby m.RollNumber
                        select m;
            model = query.ToList();

            return PartialView("_GetMonCRListView", model);
        }
        //After the Gen button is clicked on Monster, find out what Monster will be next given the dice roll number.
        public async Task<ActionResult> GetNewMonDetail(int roll, int sessionid, int cr)
        {

            Monster m = await _repo.GetMonsterByIndex(await _repo.GetRndMonsterIndexbyRoll(cr));
            
            
            //List<Monster> model = null;
            //List<MonsterCR> CRDet = null;

            //var query3 = from c in _context.CRRoll
            //             where c.SessionId == sessionid
            //             where c.RollNumber == cr
            //             select c;
            //CRRoll critem = query3.FirstOrDefault();

            //var query = from mcr in _context.MonsterCR
            //            where mcr.RollNo == roll
            //            where mcr.SessionId == sessionid
            //            where mcr.CRRollId == critem.ID
            //            select mcr;
            //CRDet = query.ToList();
            //foreach (var item in CRDet)
            //{
            //    var query2 = from m in _context.Monster
            //                 where m.ID == item.MonsterId
            //                 select m;
            //    model = query2.ToList();
            //}

            ViewBag.Roll = roll;
            return PartialView("_MonsterDetailsView", m);
        }

        /*public ActionResult GetMonQTYinput(int cr)
        {
            List<CRRoll> model = null;
            var query = from c in _context.CRRoll
                        where c.RollNumber == cr
                        select c;
            model = query.ToList();

            return PartialView("MonsterQTYInputView", model);
        }*/

        //
        //Levels/Details Ajax Calls
        //
        public async Task<ActionResult> GetMonDetails(string id)
        {

            Monster model = await _repo.GetMonsterByIndex(id);

            return PartialView("_GetMonsterView", model);
        }
        //Get Character details and display.
        public ActionResult GetCharDetails(int id , string name, int init, string charclass)
        {
            List<Session> model = null;

            var query = from s in _context.Session      
                        join l in _context.Level on s.ID equals l.SessionID
                        where l.ID == id
                        select s;
            model = query.ToList();

            return PartialView("_GetCharacterView", model);
        }

        public ActionResult GetCRPopUp(int id)
        {
            List<CRRoll> model = null;

            var query = from cr in _context.CRRoll
                        where cr.SessionId == id
                        orderby cr.RollNumber
                        select cr;
            model = query.ToList();

            return PartialView("_GetCRPopUpView", model);
        }

        // If room is changed in the top right and update is clicked,
        // Update the current room number in the DB.
        public class Data
        {
            public int id { get; set; }
            public int newRoom { get; set; }
        }
        [HttpPost]
        public async Task<IActionResult> SubmitRoom([FromBody]Data data)
        {

            var query = from s in _context.Session
                        where s.ID == data.id
                        select s;
            Session session = query.FirstOrDefault();
            if (ModelState.IsValid)
            {
                try
                {
                    session.CurrentLevel = data.newRoom;
                    _context.Update(session);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LevelExists(session.ID))
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
           return View();
        }

   

        //Load up a screen of the Current monsters in use for DM use. 
        public async Task<IActionResult> DMScreen(int? id)
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
            var query = from s in _context.Session
                        where s.ID == level.SessionID
                        select s;
            Session session = query.FirstOrDefault();

            var query2 = from m in _context.Monster
                         where m.ID == level.MonsterID
                         select m;
            Monster Mon = query2.FirstOrDefault();

            string link = Mon.Name.Replace(" ", "%20");
            //string source = Mon.Source;
            //source = source.Substring(0, source.IndexOf(" ") + 1);
            //link = link + '_' + source;
            ViewBag.Players = session.PlayerQty;
            ViewBag.MonName = Mon.Name;
            ViewBag.Link = "https://roll20.net/compendium/dnd5e/" + link + "#h-" + link;
            ViewBag.SessionID = session.ID;

            return View(level);
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
            var query = from s in _context.Session
                        where s.ID == level.SessionID
                        select s;
            Session session = query.FirstOrDefault();

            var query2 = from b in _context.Biome
                        where b.ID == level.BiomeID
                        select b;
            Biome biome = query2.FirstOrDefault();

            ViewBag.Players = session.PlayerQty;
            ViewBag.BiomeRoll = biome.RollNumber;
            ViewBag.SessionID = session.ID;

            return View(level);
        }

        // GET: Levels/Create
        [Route("Levels/Create/{id}")]
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync(s => s.ID == id);

            if (session == null)
            {
                return NotFound();
            }

            ViewBag.CRoomLevel = session.CurrentLevel;
            ViewBag.CSessionID = session.ID;


            return View();
        }



        // POST: Levels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Levels/Create/{id}")]
        public async Task<IActionResult> Create(int id, [Bind("RoomLevel,EventID,Name,SessionID,BiomeID,CRLevel,MonsterID,CurrentRoom")] Level level)
        {
            if (ModelState.IsValid)
            {
                level.SessionID = id;
                //level.CRLevel = _repo.GetCRLevel(level.SessionID, level.CRLevel);
                //level.MonsterID = await _repo.GetMonsterIDbyRoll(level.MonsterID, level.CRLevel, level.SessionID);
                level.MonsterIndex = await _repo.GetRndMonsterIndexbyRoll(level.CRLevel);
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


                level.RoomLevel = _repo.GetCurrentRoomNumber(level.SessionID) + RoomMove;

                //Edit DB Session Current Room
                _repo.UpdateCurrentRoomNumber(level.SessionID, level.RoomLevel);

                
                _context.Add(level);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Levels", new { id = level.ID });
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

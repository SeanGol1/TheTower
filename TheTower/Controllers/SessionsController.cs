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
    public class SessionsController : Controller
    {
        // Link DB Context and Repository
        private readonly TowerContext _context;
        private readonly TowerRepo _repo;

        public SessionsController(TowerContext context, TowerRepo repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: Sessions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Session.ToListAsync());
        }

        // GET: Sessions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync(m => m.ID == id);
            if (session == null)
            {
                return NotFound();
            }

            var results = _repo.GetSessionLevels(session.ID);

            ViewBag.CRoomLevel = session.CurrentLevel;
            return View(results);
        }

        // GET: Sessions/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Sessions/AddRestRooms/5
        public async Task<IActionResult> AddRestRooms(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync(m => m.ID == id);
            if (session == null)
            {
                return NotFound();
            }

            //var results = _repo.GetSessionLevels(session.ID);

            ViewBag.SessionId = session.ID;
            return View();
        }

        // POST: Sessions/AddRestRooms
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRestRooms(int id, [Bind("RoomLevel,EventID,Name,SessionID,BiomeID,CRLevel,MonsterID,CurrentRoom")] Level level)
        {
            //Add Levels to DB and return to page to add more.
            if (ModelState.IsValid)
            {
                level.SessionID = id;
                level.MonsterID = 1;                
                level.BiomeID = -1;
                level.EventID = -1;
                _context.Add(level);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("AddRestRooms", "Sessions", new { id = level.SessionID });
            }
            return View(level);
        }

        // GET: Sessions/AddPlayers/5
        public async Task<IActionResult> AddPlayers(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync(m => m.ID == id);
            if (session == null)
            {
                return NotFound();
            }

            List<Player> playerlist = null;
            var query = from p in _context.Player
                        where p.SessionId == id
                        select p;
            playerlist = query.ToList();
            ViewBag.SessionId = session.ID;
            ViewBag.PlayerQty = session.PlayerQty;
            ViewBag.PlayerCount = playerlist.Count();
                
            if (playerlist.Count() == session.PlayerQty)
            {
                return RedirectToAction("Details", "Sessions", new { id = session.ID });
            }
            return View();
        }

        // POST: Sessions/AddRestRooms
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPlayers(int id, [Bind("Name,Char")] Player player)
        {
            //Add Levels to DB and return to page to add more.
            if (ModelState.IsValid)
            {
                player.Init = 0;
                player.SessionId = id;
                _context.Add(player);
                await _context.SaveChangesAsync();

                return RedirectToAction("AddPlayers", "Sessions", new { id = player.SessionId });
            }
            return View(player);
        }


        public int GetPartyXP(int lvl, int qty)
        {
            int xp = 0;
            switch (lvl)
            {
                case 1:
                    xp = 100;
                    break;
                case 2:
                    xp = 200;
                    break;
                case 3:
                    xp = 400;
                    break;
                case 4:
                    xp = 500;
                    break;
                case 5:
                    xp = 1100;
                    break;
                case 6:
                    xp = 1400;
                    break;
                case 7:
                    xp = 1700;
                    break;
                case 8:
                    xp = 2100;
                    break;
                case 9:
                    xp = 2400;
                    break;
                case 10:
                    xp = 2800;
                    break;
                case 11:
                    xp = 3600;
                    break;
                case 12:
                    xp = 4500;
                    break;
                case 13:
                    xp = 5100;
                    break;
                case 14:
                    xp = 5700;
                    break;
                case 15:
                    xp = 6400;
                    break;
                case 16:
                    xp = 7200;
                    break;
                case 17:
                    xp = 8800;
                    break;
                case 18:
                    xp = 9500;
                    break;
                case 19:
                    xp = 10900;
                    break;
                case 20:
                    xp = 12700;
                    break;



                default:
                    break;
            }
            return (xp * qty);
        }

        // POST: Sessions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DMName,PlayerLevel,PlayerQty,RestRoomQty")] Session session)
        {
            //

            if (ModelState.IsValid)
            {
                session.XP = GetPartyXP(session.PlayerLevel, session.PlayerQty);
                session.SessionCode = GetRandomCode();
                _context.Add(session);
                _context.SaveChanges();
                Task.Delay(1000).GetAwaiter().GetResult();
                //await GetMonsterList(session);
                Task.Delay(1000).GetAwaiter().GetResult();
                await GetMonsterCRRoll(session.ID);
                return RedirectToAction("AddRestRooms", "Sessions", new { id = session.ID });
            }
            return View(session);
        }
        public int SessionCode = 0;

        public int GetRandomCode()
        {            
            Random rd = new Random();
            int code = rd.Next(100000, 999999);
            CheckSessionCode(code);
            return code;
        }
        public void CheckSessionCode(int code)
        {

            var session = _context.Session
                .FirstOrDefaultAsync(m => m.SessionCode == code);
            var query = from s in _context.Session
                        where s.SessionCode == code
                        select s;
            if (query.FirstOrDefault() == null)
            {
                
            }
            else
                GetRandomCode();


        }

        public List<Monster> TempMonList = new List<Monster>();
        public List<Monster> TempMonCRList = new List<Monster>();
        //public async Task GetMonsterList(Session session)
        //{
        //    //var query = from m in _context.Monster
        //    //            select m;
        //    //List<Monster> MonList = query.ToList();

        //    //List<int> Cr = new List<int>();

        //    //Random rd = new Random();
        //    //foreach (var mon in MonList)
        //    //{
        //    //    if (mon.XP <= (session.XP * 1.6) && mon.XP >= (session.XP * .3))
        //    //    {
        //    //        TempMonList.Add(mon);
        //    //    }
        //    //}

        //    //// Get Highest CR and Lowest CR
        //    //double high = 0;
        //    //double low = 100;
        //    //foreach (var mon in TempMonList)
        //    //{
        //    //    if (mon.ChallengeRating < low)
        //    //    {
        //    //        low = mon.ChallengeRating;
        //    //    }
        //    //    else if (mon.ChallengeRating > high)
        //    //    {
        //    //        high = mon.ChallengeRating;
        //    //    }
        //    //}
        //    ////Match CR to Roll Numbers
        //    //for (int i = 1; i < 21; i++)
        //    //{
        //    //    CRRoll crEntry = new CRRoll();
        //    //    crEntry.RollNumber = i;
        //    //    crEntry.SessionId = session.ID;
        //    //    crEntry.MonsterQTY = 1;
        //    //    if (i == 20)
        //    //    {
        //    //        crEntry.XP = high;
        //    //    }
        //    //    else
        //    //    {
        //    //        crEntry.XP = rd.Next(low, (high - 1));
        //    //    }
        //    //    crEntry.MonsterId = 2;
        //    //    _context.CRRoll.Add(crEntry);
        //    //    //GetMonsterCRRoll(crEntry);
        //    //}
        //    //await _context.SaveChangesAsync();

        //}


        public async Task GetMonsterCRRoll(int sessionid)
        {
            var query = from cr in _context.CRRoll
                        where cr.SessionId == sessionid
                        select cr;
            List<CRRoll> crlist = query.ToList();
            foreach (var item in crlist)
            {
                Random rd = new Random();
                foreach (var mon in TempMonList)
                {
                    if (item.XP == mon.ChallengeRating)
                    {
                        TempMonCRList.Add(mon);
                    }
                }
                for (int i = 1; i < 5; i++)
                {
                    MonsterCR moncr = new MonsterCR();
                    moncr.MonsterId = TempMonCRList[rd.Next(TempMonCRList.Count)].ID;
                    moncr.CRRollId = item.ID;
                    moncr.RollNo = i;
                    moncr.SessionId = sessionid;
                    _context.MonsterCR.Add(moncr);
                    var mon = await _context.Monster.FindAsync(moncr.MonsterId);
                    TempMonCRList.Remove(mon);
                    //Remove Monster from Temp List!!!
                }

                TempMonCRList.Clear();
            }
            await _context.SaveChangesAsync();

        }

        // GET: Sessions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }
            return View(session);
        }

        // POST: Sessions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DMName,PlayerLevel,PlayerQty")] Session session)
        {
            if (id != session.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(session);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionExists(session.ID))
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
            return View(session);
        }

        // GET: Sessions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync(m => m.ID == id);
            if (session == null)
            {
                return NotFound();
            }

            return View(session);
        }

        // POST: Sessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var session = await _context.Session.FindAsync(id);

            //Delete Levels.
            var query = from l in _context.Level
                        where l.SessionID == id
                        select l;
            List<Level> levels = query.ToList();
            foreach (var level in levels)
            {
                _context.Remove(level);
            }


            //Delete CRRoll.
            var query2 = from cr in _context.CRRoll
                         where cr.SessionId == id
                         select cr;
            List<CRRoll> CRRolls = query2.ToList();
            foreach (var crroll in CRRolls)
            {
                _context.Remove(crroll);
            }

            //Delete MonsterCR.
            var query3 = from mcr in _context.MonsterCR
                         where mcr.SessionId == id
                         select mcr;
            List<MonsterCR> MonCRs= query3.ToList();
            foreach (var moncr in MonCRs)
            {
                _context.Remove(moncr);
            }

            //Delete Players.
            var query4 = from p in _context.Player
                         where p.SessionId == id
                         select p;
            List<Player> players = query4.ToList();
            foreach (var p in players)
            {
                _context.Remove(p);
            }

            _context.Session.Remove(session);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessionExists(int id)
        {
            return _context.Session.Any(e => e.ID == id);
        }
    }
}

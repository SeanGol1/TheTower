using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheTower.Models;

namespace TheTower.Data
{
    public class TowerRepo
    {
        private readonly TowerContext _ctx;
        public TowerRepo(TowerContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Level> GetSessionLevels(int _sessionid)
        {
            return _ctx.Level
                .Where(l => l.SessionID == _sessionid)
                .ToList();
        }

        /*public int GetCRLevel(int _sessionid, int _CRRoll)
        {

            var CRLevel = from s in _ctx.Session
                          join mcr in _ctx.MonsterCR on s.MonsterCRID equals mcr.ID
                          join cr in _ctx.CRRoll on mcr.ID equals cr.MonsterCRID
                          where cr.RollNumber == _CRRoll
                          where s.ID == _sessionid
                          select cr.CRLevel;
                          
            return CRLevel.FirstOrDefault();
        }*/

        public int GetMonsterIDbyRoll(int _rollnumber, int _cr, int _sessionid)
        {
            List<Monster> model = null;
            MonsterCR MonCR = null;

            var query3 = from c in _ctx.CRRoll
                         where c.SessionId == _sessionid
                         where c.RollNumber == _cr
                         select c;
            CRRoll critem = query3.FirstOrDefault();

            var query = from mcr in _ctx.MonsterCR
                        where mcr.RollNo == _rollnumber
                        where mcr.SessionId == _sessionid
                        where mcr.CRRollId == critem.ID
                        select mcr;
            MonCR = query.FirstOrDefault();            


            ////////////////////////
            var result = _ctx.Monster.Where(m => m.ID == MonCR.MonsterId)
                .Select(m => m.ID)
                .ToList();

            /*var results = from m in _ctx.Monster
                          where m.RollNumber == _rollnumber
                          where m.ChallengeRating == _cr
                          select m.ID;*/

            return result.FirstOrDefault();
        }

        public string GetMonsterName(int _monsterID)
        {
            var result = from m in _ctx.Monster
                         where m.ID == _monsterID
                         select m.Name;

            return result.FirstOrDefault();
        }

        public int GetCurrentRoomNumber(int _sessionID)
        {
            var result = from s in _ctx.Session
                         where s.ID == _sessionID
                         select s.CurrentLevel;

            return result.FirstOrDefault();
        }

        public void UpdateCurrentRoomNumber(int _sessionid, int _newLevel)
        {
            var result = from s in _ctx.Session
                         where s.ID == _sessionid
                         select s;

            foreach (Session item in result)
            {
                item.CurrentLevel = _newLevel;
            }
            
        }

    }
}

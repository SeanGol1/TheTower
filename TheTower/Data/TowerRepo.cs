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

        public int GetCRLevel(int _sessionid, int _CRRoll)
        {

            var CRLevel = from s in _ctx.Session
                          join mcr in _ctx.MonsterCR on s.MonsterCRID equals mcr.ID
                          join cr in _ctx.CRRoll on mcr.ID equals cr.MonsterCRID
                          where cr.RollNumber == _CRRoll
                          where s.ID == _sessionid
                          select cr.CRLevel;

            return CRLevel.FirstOrDefault();
        }

        public int GetMonsterIDbyRoll(int _rollnumber, int _cr)
        {
            var result = _ctx.Monster.Where(m => m.RollNumber == _rollnumber && m.ChallengeRating == _cr)
                .Select(m => m.ID)
                .ToList();

            var results = from m in _ctx.Monster
                          where m.RollNumber == _rollnumber
                          where m.ChallengeRating == _cr
                          select m.ID;

            return results.FirstOrDefault();
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

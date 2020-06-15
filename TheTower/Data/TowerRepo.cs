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
    }
}

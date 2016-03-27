using InjectingMonsters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectingMonsters.Services
{
    public class MonsterService : IMonsterService
    {
        private List<Monster> _monsters;
        public MonsterService()
        {
            _monsters = new List<Monster>()
            {
                new Monster { Name = "Dave", Thumbnail = @"http://aspnetmonsters.com/images/thumb_dave.png" },
                new Monster { Name = "Simon", Thumbnail = @"http://aspnetmonsters.com/images/thumb_simon.png" },
                new Monster { Name = "James", Thumbnail = @"http://aspnetmonsters.com/images/thumb_james.png" }
            };
        }

        public Monster GetMonster()
        {
            var random = new Random(Environment.TickCount);
            return _monsters[random.Next(0, _monsters.Count())];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbaraStatistics.Data
{
    public class CharacterStats
    {
        // Eno
        public string Eno { get; set; }

        // キャラ名
        public string CharacterName { get; set; }

        // 異能
        public string[] Extraordinary { get; set; }

        // アイテム
        public string[] Item { get; set; }

        // スキル
        public string[] Skill { get; set; }

    }
}

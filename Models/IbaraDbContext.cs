using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IbaraStatistics.Models
{
    public class IbaraDbContext : DbContext
    {
        public IbaraDbContext(DbContextOptions options) : base (options) { }

        // キャラクター一覧テーブル
        public DbSet<Character> Characters { get; set; }

        // 異能テーブル
        public DbSet<Extraordinarys> Extraordinarys { get; set; }

        // アイテムテーブル
        public DbSet<Items>Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=Ibara.db");

    }
}

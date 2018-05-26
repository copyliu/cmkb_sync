using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cmkb_sync.Model
{
    public partial class Db : DbContext
    {
        private readonly string connectionString;
        public Db(string connectionString) : base()
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        public virtual DbSet<achievement_achievement> achievement_achievement { get; set; }
        public virtual DbSet<achievement_char_achievement> achievement_char_achievement { get; set; }
        public virtual DbSet<achievement_km_achivement> achievement_km_achivement { get; set; }
        public virtual DbSet<achievement_type> achievement_type { get; set; }
        public virtual DbSet<killboard_alliances> killboard_alliances { get; set; }
        public virtual DbSet<killboard_character> killboard_character { get; set; }
        public virtual DbSet<killboard_corporation> killboard_corporation { get; set; }
        public virtual DbSet<killboard_itemprice> killboard_itemprice { get; set; }
        public virtual DbSet<killboard_kill> killboard_kill { get; set; }
        public virtual DbSet<killboard_killattacker> killboard_killattacker { get; set; }
        public virtual DbSet<killboard_killitem> killboard_killitem { get; set; }
        public virtual DbSet<killboard_killmailraw> killboard_killmailraw { get; set; }
        public virtual DbSet<killboard_waiting_api> killboard_waiting_api { get; set; }


    }
}

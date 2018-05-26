using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class achievement_char_achievement
    {
        public achievement_char_achievement()
        {
            achievement_km_achivement = new HashSet<achievement_km_achivement>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Column("get")]
        public bool Get { get; set; }
        [Column("getDate")]
        public DateTimeOffset? GetDate { get; set; }
        [Column("progress")]
        public int Progress { get; set; }
        [Column("achievement_id")]
        public int AchievementId { get; set; }
        [Column("char_id")]
        public long CharId { get; set; }

        [ForeignKey("AchievementId")]
        [InverseProperty("achievement_char_achievement")]
        public achievement_achievement Achievement { get; set; }
        [ForeignKey("CharId")]
        [InverseProperty("achievement_char_achievement")]
        public killboard_character Char { get; set; }
        [InverseProperty("C")]
        public ICollection<achievement_km_achivement> achievement_km_achivement { get; set; }
    }
}

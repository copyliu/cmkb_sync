using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class achievement_km_achivement
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("cid")]
        public int Cid { get; set; }
        [Column("km_id")]
        public int KmId { get; set; }

        [ForeignKey("Cid")]
        [InverseProperty("achievement_km_achivement")]
        public achievement_char_achievement C { get; set; }
        [ForeignKey("KmId")]
        [InverseProperty("achievement_km_achivement")]
        public killboard_kill Km { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_character
    {
        public killboard_character()
        {
            achievement_char_achievement = new HashSet<achievement_char_achievement>();
            killboard_killCharacter = new HashSet<killboard_kill>();
            killboard_killFinalcharacter = new HashSet<killboard_kill>();
            killboard_killattacker = new HashSet<killboard_killattacker>();
        }

        [Key]
        [Column("characterID")]
        public long CharacterId { get; set; }
        [Column("keyid")]
        public string Keyid { get; set; }
        [Column("vcode")]
        public string Vcode { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("updtime")]
        public DateTimeOffset? Updtime { get; set; }
        [Column("istemp")]
        public bool Istemp { get; set; }
        [Column("expires")]
        public DateTimeOffset? Expires { get; set; }
        [Column("iskwin", TypeName = "numeric(20, 4)")]
        public decimal Iskwin { get; set; }
        [Column("isklost", TypeName = "numeric(20, 4)")]
        public decimal Isklost { get; set; }
        [Column("zkbpt", TypeName = "numeric(20, 4)")]
        public decimal Zkbpt { get; set; }
        [Column("lastkm")]
        public int? Lastkm { get; set; }
        [Column("points")]
        public double? Points { get; set; }
        [Column("filtered")]
        public bool? Filtered { get; set; }
        [Column("alliance_id")]
        public long? AllianceId { get; set; }
        [Column("corporation_id")]
        public long? CorporationId { get; set; }
        [Column("level_id")]
        public int? LevelId { get; set; }
        [Column("max_level_id")]
        public int? MaxLevelId { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }

        [ForeignKey("AllianceId")]
        [InverseProperty("killboard_character")]
        public killboard_alliances Alliance { get; set; }
        [ForeignKey("CorporationId")]
        [InverseProperty("killboard_character")]
        public killboard_corporation Corporation { get; set; }
        [InverseProperty("Char")]
        public ICollection<achievement_char_achievement> achievement_char_achievement { get; set; }
        [InverseProperty("Character")]
        public ICollection<killboard_kill> killboard_killCharacter { get; set; }
        [InverseProperty("Finalcharacter")]
        public ICollection<killboard_kill> killboard_killFinalcharacter { get; set; }
        [InverseProperty("Character")]
        public ICollection<killboard_killattacker> killboard_killattacker { get; set; }
    }
}

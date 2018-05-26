using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_alliances
    {
        public killboard_alliances()
        {
            killboard_character = new HashSet<killboard_character>();
            killboard_corporation = new HashSet<killboard_corporation>();
            killboard_killAlliance = new HashSet<killboard_kill>();
            killboard_killFinalalliance = new HashSet<killboard_kill>();
            killboard_killattacker = new HashSet<killboard_killattacker>();
        }

        [Key]
        [Column("allianceID")]
        public long AllianceId { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("shortName")]
        public string ShortName { get; set; }
        [Column("memberCount")]
        public int? MemberCount { get; set; }
        [Column("startDate")]
        public DateTimeOffset? StartDate { get; set; }
        [Column("updtime")]
        public DateTimeOffset? Updtime { get; set; }
        [Column("istemp")]
        public bool Istemp { get; set; }
        [Column("filtered")]
        public bool? Filtered { get; set; }
        [Column("executorCorp_id")]
        public long? ExecutorCorpId { get; set; }

        [ForeignKey("ExecutorCorpId")]
        [InverseProperty("killboard_alliances")]
        public killboard_corporation ExecutorCorp { get; set; }
        [InverseProperty("Alliance")]
        public ICollection<killboard_character> killboard_character { get; set; }
        [InverseProperty("Alliance")]
        public ICollection<killboard_corporation> killboard_corporation { get; set; }
        [InverseProperty("Alliance")]
        public ICollection<killboard_kill> killboard_killAlliance { get; set; }
        [InverseProperty("Finalalliance")]
        public ICollection<killboard_kill> killboard_killFinalalliance { get; set; }
        [InverseProperty("Alliance")]
        public ICollection<killboard_killattacker> killboard_killattacker { get; set; }
    }
}

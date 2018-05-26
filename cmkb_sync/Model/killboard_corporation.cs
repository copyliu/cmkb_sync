using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_corporation
    {
        public killboard_corporation()
        {
            killboard_alliances = new HashSet<killboard_alliances>();
            killboard_character = new HashSet<killboard_character>();
            killboard_killCorporation = new HashSet<killboard_kill>();
            killboard_killFinalcorporation = new HashSet<killboard_kill>();
            killboard_killattacker = new HashSet<killboard_killattacker>();
        }

        [Key]
        [Column("corporationID")]
        public long CorporationId { get; set; }
        [Required]
        [Column("corporationName")]
        public string CorporationName { get; set; }
        [Column("ticker")]
        public string Ticker { get; set; }
        [Column("flag")]
        public bool Flag { get; set; }
        [Column("updtime")]
        public DateTimeOffset? Updtime { get; set; }
        [Column("istemp")]
        public bool Istemp { get; set; }
        [Column("expires")]
        public DateTimeOffset? Expires { get; set; }
        [Column("keyid")]
        public string Keyid { get; set; }
        [Column("vcode")]
        public string Vcode { get; set; }
        [Column("lastkm")]
        public int? Lastkm { get; set; }
        [Column("filtered")]
        public bool? Filtered { get; set; }
        [Column("Alliance_id")]
        public long? AllianceId { get; set; }
        [Column("ceoID")]
        public long? CeoId { get; set; }
        [Column("ceoName")]
        public string CeoName { get; set; }
        [Column("stationID")]
        public long? StationId { get; set; }
        [Column("stationName")]
        public string StationName { get; set; }
        [Column("taxRate")]
        public double? TaxRate { get; set; }
        [Column("memberCount")]
        public int? MemberCount { get; set; }
        [Column("shares")]
        public int? Shares { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("url")]
        public string Url { get; set; }
        public DateTimeOffset? AlliancestartDate { get; set; }

        [ForeignKey("AllianceId")]
        [InverseProperty("killboard_corporation")]
        public killboard_alliances Alliance { get; set; }
        [InverseProperty("ExecutorCorp")]
        public ICollection<killboard_alliances> killboard_alliances { get; set; }
        [InverseProperty("Corporation")]
        public ICollection<killboard_character> killboard_character { get; set; }
        [InverseProperty("Corporation")]
        public ICollection<killboard_kill> killboard_killCorporation { get; set; }
        [InverseProperty("Finalcorporation")]
        public ICollection<killboard_kill> killboard_killFinalcorporation { get; set; }
        [InverseProperty("Corporation")]
        public ICollection<killboard_killattacker> killboard_killattacker { get; set; }
    }
}

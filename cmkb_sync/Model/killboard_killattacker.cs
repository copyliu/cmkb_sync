using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_killattacker
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("damageDone")]
        public int DamageDone { get; set; }
        [Column("finalBlow")]
        public bool FinalBlow { get; set; }
        [Column("securityStatus")]
        public double SecurityStatus { get; set; }
        [Column("Kill_id")]
        public int KillId { get; set; }
        [Column("alliance_id")]
        public long? AllianceId { get; set; }
        [Column("character_id")]
        public long? CharacterId { get; set; }
        [Column("corporation_id")]
        public long? CorporationId { get; set; }
        [Column("faction_id")]
        public int? FactionId { get; set; }
        [Column("shipType_id")]
        public int? ShipTypeId { get; set; }
        [Column("weaponType_id")]
        public int? WeaponTypeId { get; set; }

        [ForeignKey("AllianceId")]
        [InverseProperty("killboard_killattacker")]
        public killboard_alliances Alliance { get; set; }
        [ForeignKey("CharacterId")]
        [InverseProperty("killboard_killattacker")]
        public killboard_character Character { get; set; }
        [ForeignKey("CorporationId")]
        [InverseProperty("killboard_killattacker")]
        public killboard_corporation Corporation { get; set; }
        [ForeignKey("KillId")]
        [InverseProperty("killboard_killattacker")]
        public killboard_kill Kill { get; set; }
    }
}

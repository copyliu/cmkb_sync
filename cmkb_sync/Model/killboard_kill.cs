using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_kill
    {
        public killboard_kill()
        {
            achievement_km_achivement = new HashSet<achievement_km_achivement>();
            killboard_killattacker = new HashSet<killboard_killattacker>();
            killboard_killitem = new HashSet<killboard_killitem>();
        }

        [Key]
        [Column("killID")]
        public int KillId { get; set; }
        [Column("killTime")]
        public DateTimeOffset KillTime { get; set; }
        [Column("moonID")]
        public int MoonId { get; set; }
        [Column("damageTaken")]
        public int DamageTaken { get; set; }
        [Column("shipprice", TypeName = "numeric(20, 4)")]
        public decimal Shipprice { get; set; }
        [Column("finalSecurityStatus")]
        public double FinalSecurityStatus { get; set; }
        [Column("finalDamageDone")]
        public int FinalDamageDone { get; set; }
        [Column("itemdropprice", TypeName = "numeric(20, 4)")]
        public decimal Itemdropprice { get; set; }
        [Column("itemdestroyeprice", TypeName = "numeric(20, 4)")]
        public decimal Itemdestroyeprice { get; set; }
        [Column("allprice", TypeName = "numeric(20, 4)")]
        public decimal Allprice { get; set; }
        [Column("upload_time")]
        public DateTimeOffset UploadTime { get; set; }
        [Column("visiable")]
        public bool? Visiable { get; set; }
        [Column("APIverified")]
        public bool? Apiverified { get; set; }
        [Column("CRESTverified")]
        public bool? Crestverified { get; set; }
        [Column("atkcount")]
        public int Atkcount { get; set; }
        [Required]
        [Column("atkchar")]
        public long[] Atkchar { get; set; }
        [Column("atkcorp", TypeName = "jsonb")]
        public string Atkcorp { get; set; }
        [Column("atkali", TypeName = "jsonb")]
        public string Atkali { get; set; }
        [Column("location_dist")]
        public double? LocationDist { get; set; }
        [Column("alliance_id")]
        public long? AllianceId { get; set; }
        [Column("character_id")]
        public long? CharacterId { get; set; }
        [Column("corporation_id")]
        public long? CorporationId { get; set; }
        [Column("faction_id")]
        public int? FactionId { get; set; }
        [Column("finalShipTypeID_id")]
        public int? FinalShipTypeIdId { get; set; }
        [Column("finalWeaponTypeID_id")]
        public int? FinalWeaponTypeIdId { get; set; }
        [Column("finalalliance_id")]
        public long? FinalallianceId { get; set; }
        [Column("finalcharacter_id")]
        public long? FinalcharacterId { get; set; }
        [Column("finalcorporation_id")]
        public long? FinalcorporationId { get; set; }
        [Column("finalfaction_id")]
        public int? FinalfactionId { get; set; }
        [Column("location_id")]
        public int? LocationId { get; set; }
        [Column("shipType_id")]
        public int ShipTypeId { get; set; }
        [Column("solarSystem_id")]
        public int SolarSystemId { get; set; }
        [Column("war_id")]
        public int WarId { get; set; }

        [ForeignKey("AllianceId")]
        [InverseProperty("killboard_killAlliance")]
        public killboard_alliances Alliance { get; set; }
        [ForeignKey("CharacterId")]
        [InverseProperty("killboard_killCharacter")]
        public killboard_character Character { get; set; }
        [ForeignKey("CorporationId")]
        [InverseProperty("killboard_killCorporation")]
        public killboard_corporation Corporation { get; set; }
        [ForeignKey("FinalallianceId")]
        [InverseProperty("killboard_killFinalalliance")]
        public killboard_alliances Finalalliance { get; set; }
        [ForeignKey("FinalcharacterId")]
        [InverseProperty("killboard_killFinalcharacter")]
        public killboard_character Finalcharacter { get; set; }
        [ForeignKey("FinalcorporationId")]
        [InverseProperty("killboard_killFinalcorporation")]
        public killboard_corporation Finalcorporation { get; set; }
        [InverseProperty("Kill")]
        public killboard_killmailraw killboard_killmailraw { get; set; }
        [InverseProperty("Km")]
        public ICollection<achievement_km_achivement> achievement_km_achivement { get; set; }
        [InverseProperty("Kill")]
        public ICollection<killboard_killattacker> killboard_killattacker { get; set; }
        [InverseProperty("Kill")]
        public ICollection<killboard_killitem> killboard_killitem { get; set; }
    }
}

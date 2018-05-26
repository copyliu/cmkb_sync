using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_killmailraw
    {
        [Key]
        [Column("kill_id")]
        public int KillId { get; set; }
        [Column("hash")]
        public string Hash { get; set; }
        [Column("rawdata", TypeName = "jsonb")]
        public string Rawdata { get; set; }

        [ForeignKey("KillId")]
        [InverseProperty("killboard_killmailraw")]
        public killboard_kill Kill { get; set; }
    }
}

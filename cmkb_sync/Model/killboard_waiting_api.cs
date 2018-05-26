using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_waiting_api
    {
        [Key]
        [Column("killID")]
        public int KillId { get; set; }
        [Required]
        [Column("hash")]
        public string Hash { get; set; }
        [Column("error")]
        public bool? Error { get; set; }
        [Column("traceback")]
        public string Traceback { get; set; }
        [Column("fromapi")]
        public bool? Fromapi { get; set; }
    }
}

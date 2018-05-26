using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class achievement_type
    {
        public achievement_type()
        {
            achievement_achievement = new HashSet<achievement_achievement>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("classname")]
        public string Classname { get; set; }
        [Column("desc")]
        public string Desc { get; set; }

        [InverseProperty("Type")]
        public ICollection<achievement_achievement> achievement_achievement { get; set; }
    }
}

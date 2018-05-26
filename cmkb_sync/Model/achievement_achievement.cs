using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class achievement_achievement
    {
        public achievement_achievement()
        {
            InverseParent = new HashSet<achievement_achievement>();
            achievement_char_achievement = new HashSet<achievement_char_achievement>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("desc")]
        public string Desc { get; set; }
        [Column("get_threshold")]
        public int GetThreshold { get; set; }
        [Column("point")]
        public int Point { get; set; }
        [Required]
        [Column("funcname")]
        public string Funcname { get; set; }
        [Column("has_swf")]
        public bool HasSwf { get; set; }
        [Column("parent_id")]
        public int? ParentId { get; set; }
        [Column("type_id")]
        public int TypeId { get; set; }

        [ForeignKey("ParentId")]
        [InverseProperty("InverseParent")]
        public achievement_achievement Parent { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("achievement_achievement")]
        public achievement_type Type { get; set; }
        [InverseProperty("Parent")]
        public ICollection<achievement_achievement> InverseParent { get; set; }
        [InverseProperty("Achievement")]
        public ICollection<achievement_char_achievement> achievement_char_achievement { get; set; }
    }
}

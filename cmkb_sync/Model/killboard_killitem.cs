using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_killitem
    {
        public killboard_killitem()
        {
            InverseParentItem = new HashSet<killboard_killitem>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Column("droped")]
        public int Droped { get; set; }
        [Column("destroyed")]
        public int Destroyed { get; set; }
        [Column("singleton")]
        public int Singleton { get; set; }
        [Column("price", TypeName = "numeric(20, 4)")]
        public decimal Price { get; set; }
        [Column("ItemType_id")]
        public int ItemTypeId { get; set; }
        [Column("Kill_id")]
        public int KillId { get; set; }
        [Column("flag_id")]
        public short FlagId { get; set; }
        [Column("parentItem_id")]
        public int? ParentItemId { get; set; }

        [ForeignKey("KillId")]
        [InverseProperty("killboard_killitem")]
        public killboard_kill Kill { get; set; }
        [ForeignKey("ParentItemId")]
        [InverseProperty("InverseParentItem")]
        public killboard_killitem ParentItem { get; set; }
        [InverseProperty("ParentItem")]
        public ICollection<killboard_killitem> InverseParentItem { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cmkb_sync.Model
{
    public partial class killboard_itemprice
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("price", TypeName = "numeric(20, 4)")]
        public decimal Price { get; set; }
        [Column("item_id")]
        public int ItemId { get; set; }
    }
}

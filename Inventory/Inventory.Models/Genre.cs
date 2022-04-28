﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Genre: FullAuditModel
    {
        [Required]
        [StringLength(InventoryModelsConstans.MAX_GENRENAME_LENGTH)]
        public string Name { get; set; }

        public virtual List<ItemGenge> GenreItems { get; set; } = new List<ItemGenge>();
    }
}

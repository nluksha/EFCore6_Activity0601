﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Category: FullAuditModel
    {
        [Required]
        [StringLength(InventoryModelsConstans.MAX_NAME_LENGTH)]
        public string Name { get; set; }

        public virtual List<Item> Items { get; set; } = new List<Item>();

        public virtual CategoryDetail? CategoryDetail { get; set; }
    }
}

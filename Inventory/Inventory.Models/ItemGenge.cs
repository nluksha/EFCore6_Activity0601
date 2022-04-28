﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
    [Table("ItemGenges")]
    [Index(nameof(ItemId), nameof(GenreId), IsUnique = true)]
    public class ItemGenge: IIdentityModel
    {
        public int Id { get; set; }

        public virtual int ItemId { get; set; }
        public virtual Item Item { get; set; }

        public virtual int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}

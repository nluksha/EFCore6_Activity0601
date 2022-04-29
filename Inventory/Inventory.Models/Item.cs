﻿using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Item: FullAuditModel
    {
        [Required]
        [StringLength(InventoryModelsConstans.MAX_NAME_LENGTH)]
        public string Name { get; set; }

        [Range(InventoryModelsConstans.MINIMUM_QAUNTITY, InventoryModelsConstans.MAXIMUM_QAUNTITY)]
        public int Quantity { get; set; }

        [StringLength(InventoryModelsConstans.MAX_DESCRIPTION_LENGTH)]
        public string? Description { get; set; }

        [StringLength(InventoryModelsConstans.MAX_NOTES_LENGTH, MinimumLength = InventoryModelsConstans.MIN_NOTES_LENGTH)]
        public string? Notes { get; set; }
        public bool IsOnSale { get; set; }
        public DateTime? PurchasedDate { get; set; }
        public DateTime? SoldDate { get; set; }

        [Range(InventoryModelsConstans.MINIMUM_PRICE, InventoryModelsConstans.MAXIMUM_PRICE)]
        public decimal? PurchasePrice { get; set; }

        [Range(InventoryModelsConstans.MINIMUM_PRICE, InventoryModelsConstans.MAXIMUM_PRICE)]
        public decimal? CurrentOrFinalPrice { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual List<Player> Players { get; set; } = new List<Player>();

        public virtual List<ItemGenge> ItemGenres { get; set; } = new List<ItemGenge>();
    }
}
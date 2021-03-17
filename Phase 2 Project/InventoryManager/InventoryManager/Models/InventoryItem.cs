﻿using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }
    }
}
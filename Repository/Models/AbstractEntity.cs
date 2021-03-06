﻿using System;

namespace VitruviSoft.SamvelAvagyan.Repository.Models
{
    public abstract class AbstractEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}

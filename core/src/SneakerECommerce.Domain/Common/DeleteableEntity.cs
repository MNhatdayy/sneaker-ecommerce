﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Ecommerce.Domain.Entity
{
    public class DeleteableEntity : BaseEntity
    {
        public bool IsDeleted { get; set; }
    }
}

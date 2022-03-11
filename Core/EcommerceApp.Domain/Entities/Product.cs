﻿using EcommerceApp.Domain.Entities.Common;

namespace EcommerceApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        #region [Properties]
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region [Virtuals]
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
}

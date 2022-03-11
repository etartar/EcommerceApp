using EcommerceApp.Domain.Entities.Common;

namespace EcommerceApp.Domain.Entities
{
    public class Order : BaseEntity
    {
        #region [Properties]
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        #endregion

        #region [Virtuals]
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
        #endregion
    }
}

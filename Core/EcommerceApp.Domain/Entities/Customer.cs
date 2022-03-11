using EcommerceApp.Domain.Entities.Common;

namespace EcommerceApp.Domain.Entities
{
    public class Customer : BaseEntity
    {
        #region [Properties]
        public string Name { get; set; }
        #endregion

        #region [Virtuals]
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
}

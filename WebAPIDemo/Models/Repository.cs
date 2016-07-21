using System.Linq;

namespace WebAPIDemo.Models
{
    public class Repository : IRepository
    {
        #region Members

        private WebAPIDemoContext db;

        #endregion


        #region Constructor

        public Repository(WebAPIDemoContext db)
        {
            this.db = db;
        }

        #endregion

        #region methods

        public IQueryable<Order> GetAllOrders()
        {
            return db.Orders;
        }

        public IQueryable<Order> GetAllOrdersWithDetails()
        {            
            return db.Orders.Include("OrderDetails");
        }

        public Order GetAllOrdersWithDetails(int Id)
        {
            return db.Orders.Include("OrderDetails.Book").FirstOrDefault(o => o.Id == Id);
        }

        #endregion
    }
}
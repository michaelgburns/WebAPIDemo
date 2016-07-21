using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class OrderController : ApiController
    {
        #region Members

        private IRepository _repo;

        #endregion

        #region Constructor

        public OrderController(IRepository _repo)
        {
            this._repo = _repo;
            if (_repo == null) throw new ArgumentNullException("_repo");
        }

        #endregion

        #region Methods

        public IQueryable<Order> Get()
        {
            return _repo.GetAllOrders();
        }

        public IQueryable<Order> Get(bool includeDetails)
        {
            IQueryable<Order> query;

            if (includeDetails)
            {
                query = _repo.GetAllOrdersWithDetails();
            }
            else
            {
                query = _repo.GetAllOrdersWithDetails();
            }
            return query;
        }

        public Order Get(int id)
        {
            return _repo.GetOrder(id);
        }

        #endregion
    }
}

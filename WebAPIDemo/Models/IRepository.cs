using System;
using System.Linq;
namespace WebAPIDemo.Models
{
    public interface IRepository
    {
        IQueryable<Order> GetAllOrders();
        IQueryable<Order> GetAllOrdersWithDetails();
        Order GetAllOrdersWithDetails(int Id);
    }
}

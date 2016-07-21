using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPIDemo.Models
{
    public class WebAPIDemoContextInitializer : DropCreateDatabaseAlways<WebAPIDemoContext>
    {
        protected override void Seed(WebAPIDemoContext context)
        {
            var books = new List<Book>
            {
                new Book() {Name = "War and Peace", Author = "Tolstoy", Price = 19.95m},
                new Book() {Name = "As I Lay Dying", Author = "Faulner", Price = 20.95m},
                new Book() {Name = "Harry potter 1", Author = "Tolstoy", Price = 21.95m},
                new Book() {Name = "Pro win 8", Author = "Tolstoy", Price = 22.95m},
                new Book() {Name = "Book one", Author = "Tolstoy", Price = 23.95m},
                new Book() {Name = "Book two", Author = "Tolstoy", Price = 24.95m},
                new Book() {Name = "Book three", Author = "Tolstoy", Price = 25.95m}
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order() {Customer = "John Doe", OrderDate = new DateTime(2015,01,01)};
            var details = new List<OrderDetail>()
            {
                new OrderDetail() { Book = books[0], Quantity = 1, Order = order},
                new OrderDetail() { Book = books[2], Quantity = 2, Order = order},
                new OrderDetail() { Book = books[1], Quantity = 1, Order = order}
            };
            context.Orders.Add(order);
            details.ForEach(od => context.OrderDetails.Add(od));
            context.SaveChanges();

            order = new Order() {Customer = "Joe smyth", OrderDate = new DateTime(2014,09,18)};
            details = new List<OrderDetail>()
            {
                new OrderDetail() { Book = books[1], Quantity = 1, Order = order},
                new OrderDetail() { Book = books[1], Quantity = 1, Order = order},
                new OrderDetail() { Book = books[3], Quantity = 12, Order = order},
                new OrderDetail() { Book = books[4], Quantity = 3, Order = order}
            };

            context.Orders.Add(order);
            details.ForEach(od => context.OrderDetails.Add(od));
            context.SaveChanges();

            order = new Order() {Customer = "Ward Bell", OrderDate = new DateTime(2014,12,25)};
            details = new List<OrderDetail>()
            {
                new OrderDetail() { Book = books[2], Quantity = 1, Order = order},
                new OrderDetail() { Book = books[4], Quantity = 1, Order = order},
                new OrderDetail() { Book = books[3], Quantity = 1, Order = order},
                new OrderDetail() { Book = books[1], Quantity = 3, Order = order}
            };

            context.Orders.Add(order);
            details.ForEach(od => context.OrderDetails.Add(od));
            context.SaveChanges();

 	        base.Seed(context);
        }
    }
}
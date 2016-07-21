using System.Linq;
using Breeze.ContextProvider.EF6;

namespace WebAPIDemo.Models
{
    public class Repository : IRepository
    {
        #region Members

        //private WebAPIDemoContext db;
        private readonly EFContextProvider<WebAPIDemoContext> _contextProvider = new EFContextProvider<WebAPIDemoContext>();

        #endregion


        //#region Constructor

        //public Repository(WebAPIDemoContext db)
        //{
        //    this.db = db;
        //}

        //#endregion

        #region methods

        

        #endregion

        public string MetaData
        {
            get { return _contextProvider.Metadata(); }
        }

        public Breeze.ContextProvider.SaveResult SaveChanges(Newtonsoft.Json.Linq.JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

        public IQueryable<Book> Books()
        {
            return _contextProvider.Context.Books;
        }

        public IQueryable<Order> Orders()
        {
            return _contextProvider.Context.Orders;
        }
    }
}
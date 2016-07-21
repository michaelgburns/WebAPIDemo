using Breeze.ContextProvider;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    
    [BreezeController]
    public class BreezeController : ApiController 
    {
        private readonly IRepository _repo;

        public BreezeController(IRepository _repo)
        {
            this._repo = _repo;            
            if (_repo == null) throw new ArgumentNullException("_repo");
        }

        [HttpGet]
        public string MetaData()
        {
            return _repo.MetaData;
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _repo.SaveChanges(saveBundle);
        }

        [HttpGet]
        public  IQueryable<Book> Books()
        {
            return _repo.Books();
        }

        [HttpGet]
        public IQueryable<Order> Orders()
        {
            return _repo.Orders();
        }
            
    }

}
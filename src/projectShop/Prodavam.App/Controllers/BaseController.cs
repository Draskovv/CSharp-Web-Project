using Prodavam.App;
using Microsoft.AspNetCore.Mvc;
using Prodavam.App.Data;

namespace Prodavam.App.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            this.Context = new ProdavamDbContext();
        }

        public ProdavamDbContext Context { get; set; }
    }
}

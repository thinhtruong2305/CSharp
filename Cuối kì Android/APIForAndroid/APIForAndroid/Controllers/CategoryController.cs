using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIForAndroid.Models;

namespace APIForAndroid.Controllers
{
    public class CategoryController : ApiController
    {
        CandybugWinformEntities db = new CandybugWinformEntities();

       
        public IHttpActionResult getCategory()
        {
            var listCate = (from c in db.Categories 
                           select new 
                           {
                               id = c.Id,
                               name = c.Name,
                           }).ToList();
            return Ok(listCate);
        } 

    }
}

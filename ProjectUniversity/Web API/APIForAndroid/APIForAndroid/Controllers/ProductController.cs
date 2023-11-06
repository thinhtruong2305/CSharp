using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIForAndroid.Models;
using Newtonsoft.Json;

namespace APIForAndroid.Controllers
{
    public class ProductController : ApiController
    {
        CandybugWinformEntities db = new CandybugWinformEntities();
        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult Get()
        {
            var list = (from c in db.Products
                        select new
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Category = c.Category.Name,
                            Price = c.Price,
                            Producer = c.Producer.Name,
                            Quantity = c.Quantity,
                            Discount = c.Discount,
                            Description = c.Description,
                            Image = "http://candybug.somee.com/Content/Client/img/" + c.Image
                        }).ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult getNewProduct()
        {
            var list = (from c in db.Products
                        orderby c.DateCreate descending
                        select new
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Category = c.Category.Name,
                            Price = c.Price,
                            Producer = c.Producer.Name,
                            Quantity = c.Quantity,
                            Discount = c.Discount,
                            Description = c.Description,
                            Image = "http://candybug.somee.com/Content/Client/img/" + c.Image
                        }).ToList().Take(6);
            return Ok(list);
        }

        [HttpGet]
        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
           var product = (from c in db.Products
                            where c.Id == id
                            select new
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Category = c.Category.Name,
                                Price = c.Price,
                                Producer = c.Producer.Name,
                                Quantity = c.Quantity,
                                Discount = c.Discount,
                                Description = c.Description,
                                Image = "http://ushop.somee.com/Content/Client/img/" + c.Image
                            });
            return Ok(product);
        }

        [HttpGet]
        public IHttpActionResult getProbyCate(int idCate,[FromUri] int page)
        {
            int space=6;
            int limit= (page-1) * space ;
            var product = (from c in db.Products
                           where c.IdCategory == idCate
                           orderby c.Id ascending
                           select new
                           {
                               Id = c.Id,
                               Name = c.Name,
                               Category = c.Category.Name,
                               Price = c.Price,
                               Producer = c.Producer.Name,
                               Quantity = c.Quantity,
                               Discount = c.Discount,
                               Description = c.Description,
                               Image = "http://ushop.somee.com/Content/Client/img/" + c.Image
                           }).Skip(limit).Take(space);
            return Ok(product);
        }

        [Route("api-searchProduct/{key}")]
        [HttpGet]
        public IHttpActionResult searchProduct(string key, [FromUri] int page)
        {
            int space = 6;
            int limit = (page - 1) * space;
            var product = (from c in db.Products
                           where c.Name.Contains(key)
                           orderby c.Id ascending
                           select new
                           {
                               Id = c.Id,
                               Name = c.Name,
                               Category = c.Category.Name,
                               Price = c.Price,
                               Producer = c.Producer.Name,
                               Quantity = c.Quantity,
                               Discount = c.Discount,
                               Description = c.Description,
                               Image = "http://ushop.somee.com/Content/Client/img/" + c.Image
                           }).Skip(limit).Take(space);
            return Ok(product);
        }

    }
}
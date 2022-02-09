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
    public class OrderController : ApiController
    {
        private CandybugWinformEntities DBCandyBug = new CandybugWinformEntities();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("getMaxIdOrder")]
        [HttpGet]
        public int GetIdOrder()
        {
            int a = 0;
            var danhSach = DBCandyBug.Oders.ToList();

            foreach (var item in danhSach)
            {
                if (item.Id > a)
                    a = item.Id;
            }

            return a;
        }

        [Route("getTongSoLuongOrderChuaDuyet")]
        [HttpGet]
        public int GetTongSoLuongOrderChuaDuyet()
        {
            int soLuong = DBCandyBug.Oders.Where(h => h.Status.Equals("CHƯA DUYỆT")).Count();
            return soLuong;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        [Route("createOrder")]
        [HttpPost]
        public IHttpActionResult CreateOrder([FromBody] Oder order)
        {
            Oder oder = new Oder()
            {
                IdAcc = order.IdAcc,
                DateCreate = DateTime.Now,
                Status = order.Status,
                DeliveryDate = null,
                Address = order.Address,
                SDT = order.SDT
            };
            Oder oderFind = DBCandyBug.Oders.Add(oder);
            DBCandyBug.SaveChanges();
            return Ok(oderFind);
        }

        [Route("api-viewOrder/{idAcc}")]
        [HttpGet]
        public IHttpActionResult ViewOrder(int idAcc)
        {
            var listOrder = (from c in DBCandyBug.Oders
                             where c.IdAcc == idAcc
                             select new
                             {
                                 Id = c.Id,
                                 DateCreate = c.DateCreate,
                                 Status = c.Status,
                                 Address = c.Address,
                                 SDT = c.SDT,
                                 tongTien = c.OrderInfoes.Sum(u => u.Total)
                             }).ToList();
            return Ok(listOrder);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public String Delete(int id)
        {
            var order = DBCandyBug.Oders.Find(id);
            DBCandyBug.Oders.Remove(order);
            DBCandyBug.SaveChanges();
            return "Cancel success";
        }
    }
}
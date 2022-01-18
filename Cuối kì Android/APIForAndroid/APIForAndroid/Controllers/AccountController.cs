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
    public class AccountController : ApiController
    {
        CandybugWinformEntities db = new CandybugWinformEntities();

        [HttpPost]
        public IHttpActionResult Login([FromBody] Account account)
        {
            var accountLogin = (from c in db.Accounts
                                where c.UserName == account.UserName && c.PassWord == account.PassWord
                                select new
                                {
                                    Id = c.Id,
                                    UserName = c.UserName,
                                    PassWord = c.PassWord,
                                    DisplayName = c.DisplayName,
                                    Email = c.Email,
                                    SDT = c.SDT,
                                }).FirstOrDefault();
            if (accountLogin != null)
            {
                return Ok(accountLogin);
            }
            return null;
        }

        [Route("api-register")]
        [HttpPost]
        public IHttpActionResult Register([FromBody] Account account)
        {

            var accountCheck = db.Accounts.Where(c => c.UserName == account.UserName).ToList();
            if (accountCheck.Count() > 0)
            {
                return null;
            }
            db.Accounts.Add(account);
            db.SaveChanges();
            return Ok(account);
        }

    }
}
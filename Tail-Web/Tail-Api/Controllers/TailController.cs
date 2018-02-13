using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tail_Api.Models;
using Tail_Impl;

namespace Tail_Api.Controllers
{
    public class TailController : ApiController
    {
        private static long count = 0;

        public IHttpActionResult Post([FromBody] TailRequest tailRequest)
        {
            var line = $"Line Number {++count}";
            return Ok(line);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PMS_API.Controllers
{
    public class PMSController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetDetails() {
            return Ok("Working....");
        }
    }
}

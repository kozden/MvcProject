using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebUI.identity
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; internal set; }
        public string Surname { get; internal set; }

     
    }
}
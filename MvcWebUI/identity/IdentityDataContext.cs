using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebUI.identity
{
    public class IdentityDataContext: IdentityDbContext<ApplicationUser>
    {
        //connection string yazmamız gerekli
        public IdentityDataContext() : base("dataConnection")
        {
           
        }
    }
}
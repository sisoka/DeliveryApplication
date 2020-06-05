using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Panda.Domain
{
    public class PandaUser : IdentityUser
    {
        public PandaUser()
        {
            this.Packages = new HashSet<Package>();
            this.Receipts = new HashSet<Receipt>();
            this.Id = Guid.NewGuid().ToString();
        }

        public ICollection<Package> Packages { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
    }
}

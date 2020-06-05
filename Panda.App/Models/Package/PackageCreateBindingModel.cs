using Panda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panda.App.Models.Package
{
    public class PackageCreateBindingModel
    {
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public string Recipient { get; set; }

        public ICollection<PandaUser> Recipients { get; set; } = new List<PandaUser>();
    }
}

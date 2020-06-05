using System;
using System.Collections.Generic;
using System.Text;

namespace Panda.Domain
{
    public class Receipt
    {
        public Receipt()
        {
            this.ReceiptId = Guid.NewGuid().ToString();
        }
        public string ReceiptId { get; set; }

        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; }

        public string RecipientId { get; set; }
        public PandaUser Recipient { get; set; }

        public string PackageId { get; set; }
        public Package Package { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class MaterialInvoice : Invoice
    {
        public bool ReturnStatus { get; set; }

        public MaterialInvoice(int invoiceID, DateTime loaningDate, int AccID, bool returnStatus)
            : base(invoiceID, loaningDate,AccID )
        {
            this.ReturnStatus = returnStatus;
        }

    }
}

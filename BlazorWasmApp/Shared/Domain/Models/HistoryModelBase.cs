using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmApp.Shared.Domain.Models
{
    public class HistoryModelBase : ModelBase
    {
        public DateTime PeriodEnd { get; set; }
        public DateTime PeriodStart { get; set; }
    }
}

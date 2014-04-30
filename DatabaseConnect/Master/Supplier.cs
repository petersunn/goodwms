using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnect.Master
{
    public class Supplier
    {
        [Key]
        public int SupId { get; set; }
        public string SupName { get; set; }
        public string SupAddress { get; set; }
    }
}

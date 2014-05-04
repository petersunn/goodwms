using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseConnect.Master
{
    public class PartMaster
    {
        [Key]
        public int PartId { get; set; }
        public string PartNumber { get; set; }
        public string PartDesc { get; set; }
        public string PartFamily { get; set; }
        public int PartType { get; set; }
        public string PartRev { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}

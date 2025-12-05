using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CraftsmanCity: BaseModel
    {
       

        [ForeignKey("Craftsman")]
        public int CraftsmanId { get; set; }
        public virtual Craftsman Craftsman { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual City City { get; set; }

        public bool IsPrimary { get; set; }
    }
}

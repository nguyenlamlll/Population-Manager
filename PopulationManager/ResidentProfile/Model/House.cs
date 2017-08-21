using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Model
{
    public class House
    {
        public long HouseId { get; set; }

        public string RegisteredAddress { get; set; }

        [ForeignKey("Owner")]
        public long OwnerId { get; set; }
        public Resident Owner { get; set; }
    }
}

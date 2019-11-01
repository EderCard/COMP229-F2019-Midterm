using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_Midterm.Models
{
    public class Car
    {
        public string LicensePlate { get; set; }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public int Make { get; set; }
        public string Model { get; set; }
        public bool HasFourDoor { get; set; }
        public bool HasEthanol { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now; // default DateTime on patient creation
    }
}

using COMP229_F2019_Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_Midterm.Controllers
{
    public class Repository
    {
        // list of patients
        private static List<Car> carList = new List<Car>
        {
           // initial value
           new Car
           {
                LicensePlate = "EDER229",
                OwnerName = "Ederson Cardoso",
                OwnerAddress = "941 Progress Av.",
                Make = 2,
                Model = "Corolla XE",
                HasFourDoor = true,
                HasEthanol = true,
                HasFourWheelDrive = true,
                RegistrationDate = new DateTime(2019,11,1,15,01,21)
           }
        };

        /// <summary>
        /// This method returns a list of patients
        /// </summary>
        public static IEnumerable<Car> CarList
        {
            get
            {
                return carList;
            }
        }
        /// <summary>
        /// This method add patients into the patientList
        /// </summary>
        /// <param name="patient"></param>
        public static void AddCar(Car car)
        {
            carList.Add(car);
        }
    }
}

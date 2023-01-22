using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoParking.Models;

namespace AutoParking
{
    public class AutoParkingManager
    {
        public AutoParkingManager AddAuto(AutoParkingModel automodel)
        {
            using (var context = new AutoParkingContext())
            {
                context.Autos.Add(automodel);
                context.SaveChanges();
            }
            return this;
        }
       public AutoParkingManager RemoveAuto(int id)
        {
            using (var context = new AutoParkingContext ())
            {

            }
       }
    }
};

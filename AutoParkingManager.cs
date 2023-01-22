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
        public AutoParkingManager UpdateAuto( AutoParkingModel automodel)
        {
            using (var context = new AutoParkingContext())
            {

                context.Autos.Update(automodel);
                context.SaveChanges();
            }
            return this;
        }
        public AutoParkingManager RemoveAuto(int id)
        {
            AutoParkingModel automodeltodelete;
            using (var context = new AutoParkingContext())
            {
                automodeltodelete = context.Autos.Single(x => x.Id == id);
                context.Autos.Remove(automodeltodelete);
                context.SaveChanges();
            }
            return this;
        }
        public AutoParkingManager sprzedajAuto(AutoParkingModel automodel)
        {
            using (var context = new AutoParkingContext())
            {
                automodel.czysprzedany = true;
                this.UpdateAuto(automodel);
            }
            return this;
        }
        public AutoParkingModel GetAuto(int id)
        {
            using (var context = new AutoParkingContext())
            {
                var auto = context.Autos.Single(x => x.Id == id);
                return auto;
            }
        }
        public List<AutoParkingModel> GetAutos()
        {
            using (var context = new AutoParkingContext())
            {
                var auta = context.Autos.ToList();
                return auta;
            }
        }
    }
};

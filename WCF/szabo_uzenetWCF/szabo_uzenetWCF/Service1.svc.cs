using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using szabo_uzenetWCF.Interfaces;
using szabo_uzenetWCF.Models;
using szabo_uzenetWCF.Services;

namespace szabo_uzenetWCF
{
    public class Service1 : IService1
    {
        public string CreateUzenet(Uzenet uzenet)
        {
            return new UzenetService().Create(uzenet);
        }

        public List<Uzenet> GetAllUzenet()
        {
            List<Tablazat> tablazatok = new UzenetService().Read();
            List<Uzenet> uzenetList = new List<Uzenet>();

            foreach (Tablazat elem in tablazatok)
            {
                uzenetList.Add(elem as Uzenet);
            }
            return uzenetList;
        }

        public string UpdateUzenet(Uzenet uzenet)
        {
            return new UzenetService().Update(uzenet);
        }

        public string DeleteUzenet(int id)
        {
            return new UzenetService().Delete(id);
        }
    }
}

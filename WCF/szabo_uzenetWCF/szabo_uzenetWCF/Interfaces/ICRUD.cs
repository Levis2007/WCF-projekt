using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using szabo_uzenetWCF.Models;

namespace szabo_uzenetWCF.Interfaces
{
    public interface ICRUD
    {
        string Create(Tablazat tablazat);

        List<Tablazat> Read();

        string Update(Tablazat tablazat);

        string Delete(int id);
    }
}

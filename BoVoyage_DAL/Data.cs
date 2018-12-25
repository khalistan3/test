using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage_DAL
{
    public class DataPool
    {
        public static BVContext BoVContext = new BVContext();  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lombard_Soldatov.Controller
{
    internal class DBConnection
    {
        private static Model.LombardEntities db;
        public static Model.LombardEntities GetContext()
        {
            if (db == null)
            {
                db = new Model.LombardEntities();
            }
            return db;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakery.AccessDb;

namespace Bakery.HandleData
{
    public class CakeData
    {
        static CakeData instance = null;
        
        public static CakeData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CakeData();
                }
                return instance;
            }
        }

        private CakeData() { }
    }
}

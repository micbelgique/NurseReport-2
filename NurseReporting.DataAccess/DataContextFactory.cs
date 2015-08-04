using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.DataAccess
{
    public class DataContextFactory
    {
        private static volatile object _locker = new object();
        private static DataContextFactory _instance;

        private DataContextFactory()
        { }

        public static DataContextFactory Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new DataContextFactory();
                    }
                    return _instance;
                }
            }
        }

        public DataContext Create()
        {
            return new DataContext();
        }
    }
}

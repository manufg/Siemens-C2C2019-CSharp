using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRMSAPP.Entities;
using HRMSAPP.Repository;

namespace HRMSAPP.DataAccessLayer
{
    public class EmployeeDao
    {
        private Employee[] _dataStore;
        public EmployeeDao()
        {
            _dataStore = EmployeeRepository.Get();
        }
        public Employee[] GetEmployees()
        {
            return _dataStore;
        }
        public bool Add(Employee employee)
        {
            Nullable<int> index = null;
            if (_dataStore != null)
            {
                for (int i = 0; i < _dataStore.Length; i++)
                {
                    if (_dataStore[i] == null)
                    {
                        index = i;
                        break;
                    }
                }
            }
            if (index.HasValue)
            {
                _dataStore[index.Value] = employee;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

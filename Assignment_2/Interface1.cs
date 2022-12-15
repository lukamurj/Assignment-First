using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
     public interface Interface<T> where T : Person
    {
        T CreateStudentsList(Name name);
        public IEnumerable<T> GetStudentsList();
        public IEnumerable<T> GetStudentsListSortedBy(IEnumerable<T> list, string parameter);
        public IEnumerable<T> GetStudentsListSorted(List<T> list);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class InterfaceImplementation : Interface<Person>
    {
        public List<Name> names = new List<Name>();
        public InterfaceImplementation()
        {
            names.Add(new Name("Luka", "Murjikneli"));
            names.Add(new Name("Giorgi", "Merabishvili"));
            names.Add(new Name("Avtandil", "Ushikashvili"));
            names.Add(new Name("Gocha", "WavWavadze"));
            names.Add(new Name("Mari", "Sherazadishvili"));
            names.Add(new Name("Lika", "Mesxi"));
            names.Add(new Name("Dato", "Kachkachashvili"));
            names.Add(new Name("Nika", "Tedoradze"));
            names.Add(new Name("Tamari", "Machavariani"));
            names.Add(new Name("Nino", "Meliqidze"));
        }

        Person Interface<Person>.CreateStudentsList(Name name)
        {
            Person student = new Student(name.First, name.Last);
            return student;
        }
        public IEnumerable<Person> GetStudentsList()
        {
            foreach (var item in names)
            {
                Person person = new Student(item.First, item.Last);
                yield return person;
            }
        }
        public IEnumerable<Person> GetStudentsListSortedBy(IEnumerable<Person> list, string parameter)
        {
            List<Person> list_2 = new List<Person>();
            foreach (var item in list)
            {
                if(item.FirstName == parameter)
                {
                    list_2.Add(item);
                }else if (item.LastName == parameter)
                {
                    list_2.Add(item);
                }
            }
            return list_2;
        }
        public IEnumerable<Person> GetStudentsListSorted(List<Person> list)
        {
            // es amdeni shemowmeba yoveli shemtxvevistvis rom saxelebs rom erti da igive pirveli ramodenime aso hqondet swored rom daalagos mainc

            for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    bool Boolean = false;
                    for(int a = 0; a < list[i].LastName.Length; a++)
                    {
                        if(a == list[j].LastName.Length)
                        {
                            break;
                        }
                        if((int)list[i].LastName.ToLower()[a] < (int)list[j].LastName.ToLower()[a])
                        {
                            break;
                        }else if ((int)list[i].LastName.ToLower()[a] > (int)list[j].LastName.ToLower()[a])
                        {
                            Boolean = true;
                            break;
                        }
                    }
                    if (Boolean == true)
                    {
                        Student student = new Student(list[i].FirstName, list[i].LastName);
                        list[i].FirstName = list[j].FirstName;
                        list[i].LastName = list[j].LastName;
                        list[j].FirstName = student.FirstName;
                        list[j].LastName = student.LastName;
                    }
                }
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class SearchSystem <T>
    {
        public static List<T> Search(string[] textSearch, List<T> list)
        {
            List<T> employees = new List<T>();

            employees.Clear();

            foreach (T e in list)
            {
                int count = 0;
                for (int i = 0; i < textSearch.Length; i++)
                {
                    if (e.ToString().ToLower().Contains(textSearch[i]))
                    {
                        count++;
                        if (count == textSearch.Length)
                        {
                            employees.Add(e);
                        }
                    }
                }
            }

            return employees;
        }
    }
}

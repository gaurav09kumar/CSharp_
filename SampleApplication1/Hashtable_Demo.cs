using System;
using System.Collections;
using System.Text;

namespace SampleApplication1
{
    class Hashtable_Demo
    {

        public void Hash_table()
        {
            Hashtable ht = new Hashtable();

            ht.Add("Emp_ID",100);
            ht.Add("EmpName", "ABC");
            ht.Add("EmpSalary", 10000f);

            Console.WriteLine("The key value pair in the hash table are :");
            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key + " : " +ht[key]);
            }
;        }
        
    }
}

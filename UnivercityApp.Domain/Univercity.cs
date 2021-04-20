using System;
using System.Collections.Generic;
using System.Text;

namespace UnivercityApp.domain
{
    public class Univercity
    {
        
        // Constructor
        public Univercity()
        {
            Students = new List<Student>();
        }
        /**/
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // عشان الجامعة يبقى عندها ليستة من الطلبة
        public List<Student> Students { get; set; }
        

    }
}

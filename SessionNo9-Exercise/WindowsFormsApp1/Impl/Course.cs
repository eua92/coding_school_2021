using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl
{
    public class Course : Entity
    {
        public string Code { get; set; }
        public string Subject { get; set; }

        public Course(): base()
        {
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl
{
    public class Grade : Entity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int Value { get; set; }

        public Grade(): base()
        {
            
        }
    }
}

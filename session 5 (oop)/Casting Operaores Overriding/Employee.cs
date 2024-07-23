using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_5__oop_.Casting_Operaores_Overriding
{
    //Model -- class that represnting table exist in database
    internal class Employee
    {
        public int? Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public Guid Security  { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class TriggeredByModel
    {
        public string Name { get; set; }
        private string RoleSetter;

        public string Role
        {
            get { return RoleSetter; }
            set { RoleSetter = value; }
        }
    }
}

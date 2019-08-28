using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Trainer : Person
    {
        string domain;
        public Trainer()
        {

        }
        public Trainer(string name, string domain) : base(name)
        {
            //this.name = name;
            this.domain = domain;
        }
        public string Domain { get => domain; set => domain = value; }

        public override string PrintInformation()
        {
            return $"{base.PrintInformation()} and Domain{this.domain}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject;

public class Person
{
    public string Name { get; set; }
    public string Family { get; set; }

    public virtual void ShowName()
    {
        Console.WriteLine("Name:" + Name + "Family:" + Family);
    }
}

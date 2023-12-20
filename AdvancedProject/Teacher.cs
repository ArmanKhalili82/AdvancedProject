using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject;

public class Teacher: Person
{
    public string Course { get; set; }

    public override void ShowName()
    {
        Console.WriteLine("Name:" + Name + "Family:" + Family + "Course:" + Course);
    }
}

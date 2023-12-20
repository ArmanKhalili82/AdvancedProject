using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject;

public class Student<T>: Person
{
    public int Score { get; set; }

    public override void ShowName()
    {
        Console.WriteLine("Name:" + Name + "Family:" + Family + "Score:" + Score );
    }
}

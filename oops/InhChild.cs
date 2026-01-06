using System;


namespace Practice.oops
{
 class InhChild: InheritancePar
    {

public void Teacher()
        {
            Console.WriteLine("maths teacher");
        }
public static void Main(string[]args)
        {
            InhChild ic = new InhChild();
            ic.School();
            ic.location();
            ic.Teacher();
        }

       

       

    }
}

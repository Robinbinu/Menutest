using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menutest
{
    internal class CGPAnext
    {
      // int si;
       public string[] Depts = { "CSE", "ECE", "EIE", "CHE", "MEC","EEE","CE","IT" };
       public string[] Sems = {"1","2","3","4","5","6","7","8"};
       public  string deptprompt = "Enter your Department:";
       public string semprompt = "Enter your Semester";
       public CGPA cgpa = new CGPA();
        public CGPAnext()
        {
           
        }

        public void inputfirst()
        {

            Menu menu = new Menu(deptprompt, Depts, 0, 2);
            menu.DisplayOps();
        }
        public void CGPAdeptnext(int deptindex)
        {
            cgpa.Dept = Depts[deptindex];
         }

        public void CGPAsemnext()
        {
            WriteLine(semprompt+"\n1 / 2 / 3 / 4 / 5 / 6 / 7 / 8\n");
            Write(":");
            cgpa.sem = ReadLine();
            cgpa.selected();
        }
    }
}

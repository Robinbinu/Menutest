using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menutest
{
    internal class Phonebook
    {
        private string prompt = @"
                                 Hello User!!! what's your choice?
                                 Welcome to Inspire Phonebook
                                 For all your contact management services
";
        private string[] options = { "New Contact", "Show all contacts","Search Contact","Exit" };
        private int selectedindex = 0;

        public Phonebook()
        {
            //id = 1 for phonenext menu
            Menu menu = new Menu(prompt,options,selectedindex,1);
            menu.DisplayOps();
        }
    }
}

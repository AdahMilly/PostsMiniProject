using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsMiniProject.Models
{
    public class User
    {
        //Step One: Display all users from the user API on the console 

        //Step two:  on selecting a user display his posts on the console 

        //Step three:  On selecting a post display the posts comments on the console
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P6Assets20241_AllanD.Models;

namespace P6Assets20241_AllanD.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public UserPost MyUserToPost { get; set; }

        //TODO: crear modelos para el rol 

        public UserViewModel()
        {
            MyUserToPost = new UserPost();
        }


    }

}

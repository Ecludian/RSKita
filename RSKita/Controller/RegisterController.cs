using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSKita.Controller
{
    class RegisterController
    {
        View.RegisterPage view;
        Model.ModelRegister model;

        private Boolean hasil;

        public RegisterController(View.RegisterPage view)
        {
            this.view = view;
            model = new Model.ModelRegister();
        }
  
        public bool insertUser()
        {
            model.namaUser = view.txtName.Text;
            model.emailUser = view.txtEmail.Text;
            model.passwordUser = view.txtPassword.Text;
            hasil = model.Registeruser();
            return hasil;
        }
    }
}

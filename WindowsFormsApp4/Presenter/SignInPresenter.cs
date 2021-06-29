using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.View;

namespace WindowsFormsApp4.Presenter
{
    public class SignInPresenter
    {
        ISignInView view;
        public SignInPresenter(ISignInView singInForm)
        {
            this.view = singInForm;
            singInForm.signInPresenter = this;
        }

        public void ErrorMessage(string error = "")
        {
            view.ErrorMessage = error;
        }
    }
}

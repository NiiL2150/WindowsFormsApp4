using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Presenter;

namespace WindowsFormsApp4.View
{
    public interface ISignInView
    {
        string UserName { get; set; }
        string Pass { get; set; }
        string ErrorMessage { get; set; }
        SignInPresenter signInPresenter { get; set; }
        IAuthoView parentForm { get; set; }
        void CloseReturn();
    }
}

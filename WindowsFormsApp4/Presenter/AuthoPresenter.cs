using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;
using WindowsFormsApp4.Repository;
using WindowsFormsApp4.View;

namespace WindowsFormsApp4.Presenter
{
    public class AuthoPresenter
    {
        public IUserRepository repository;
        IAuthoView view;

        public AuthoPresenter(IAuthoView authoForm, IUserRepository repository)
        {
            this.view = authoForm;
            authoForm.authoPresenter = this;
            this.repository = repository;
        }

        public void ErrorMessage(string error = "")
        {
            view.ErrorMessage = error;
        }

        public bool LogIn(string UserName, string Pass)
        {
            User user = view.authoPresenter.repository.GetUserByName(UserName);
            if (user != null)
            {
                if (Pass == user.Password)
                {
                    ErrorMessage();
                    return true;
                }
                else
                {
                    ErrorMessage("Password is incorrect!");
                }
            }
            else
            {
                ErrorMessage("No such user is registered!");
            }
            return false;
        }
    }
}

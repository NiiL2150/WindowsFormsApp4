﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;
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

        public bool SignIn(string UserName, string Pass)
        {
            User user = view.parentForm.authoPresenter.repository.GetUserByName(UserName);
            if (user == null)
            {
                if (UserName.Length != 0 && Pass.Length != 0)
                {
                    ErrorMessage();
                    view.parentForm.authoPresenter.repository.SaveUser(new User(UserName, Pass));
                    return true;
                }
                else
                {
                    ErrorMessage("Can't be null!");
                }
            }
            else
            {
                ErrorMessage("This user already exists!");
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;
using WindowsFormsApp4.View;

namespace WindowsFormsApp4.Presenter
{
    public class LoggedInPresenter
    {
        ILoggedInView view;

        public LoggedInPresenter(ILoggedInView loggedInForm, IAuthoView authoView, User user)
        {
            this.view = loggedInForm;
            loggedInForm.loggedInPresenter = this;
            view.parentForm = authoView;
            view.LoggedInUser = user;
            view.Author = user.Name;
            view.FindUser = view.LoggedInUser;
            view.PostMaximum = user.Posts.Count - 1;
            view.PostNumber = view.PostMaximum;
            view.FoundPost = user.Posts[view.PostNumber];
        }

        public void MyPageLoad()
        {
            view.FindUser = view.LoggedInUser;
            view.Author = view.FindUser.Name;
            view.PostMaximum = view.FindUser.Posts.Count - 1;
            view.PostNumber = view.PostMaximum;
            view.FoundPost = view.FindUser.Posts[view.PostNumber];
            view.CanEdit = true;
            view.IsEditing = false;
        }

        public void SearchUser()
        {
            User user = view.parentForm.authoPresenter.repository.GetUserByName(view.FindUserName);
            if (user != null)
            {
                view.FindUser = user;
                view.Author = view.FindUser.Name;
                view.PostMaximum = view.FindUser.Posts.Count - 1;
                view.PostNumber = view.PostMaximum;
                view.FoundPost = view.FindUser.Posts[view.PostNumber];
                view.CanEdit = false;
                view.IsEditing = false;
            }
        }

        public void ChangePost()
        {
            view.FoundPost = view.FindUser.Posts[view.PostNumber];
            view.IsEditing = false;
        }

        public void NewPost()
        {
            view.LoggedInUser.Posts.Add(view.NewPost);
            view.parentForm.authoPresenter.repository.SaveUser(view.LoggedInUser);
            MyPageLoad();
        }

        public void EditPost()
        {
            if (view.IsEditing)
            {
                view.LoggedInUser.Posts[view.PostNumber] = view.FoundPost;
                view.parentForm.authoPresenter.repository.SaveUser(view.LoggedInUser);
                MyPageLoad();
            }
            view.IsEditing = !view.IsEditing;
        }
    }
}

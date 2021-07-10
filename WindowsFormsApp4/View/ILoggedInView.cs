using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Presenter;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4.View
{
    public interface ILoggedInView
    {
        User FindUser { get; set; }
        User LoggedInUser { get; set; }
        int PostNumber { get; set; }
        int PostMaximum { get; set; }
        string FindUserName { get; set; }
        string FoundPost { get; set; }
        string NewPost { get; set; }
        string Author { get; set; }
        bool IsEditing { get; set; }
        bool CanEdit { get; set; }
        LoggedInPresenter loggedInPresenter { get; set; }
        IAuthoView parentForm { get; set; }
        void CloseReturn();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;
using WindowsFormsApp4.Presenter;

namespace WindowsFormsApp4.View
{
    public interface IAuthoView
    {
        string UserName { get; set; }
        string Pass { get; set; }
        string ErrorMessage { get; set; }
        AuthoPresenter authoPresenter { get; set; }
    }
}

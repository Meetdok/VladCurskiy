using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VladCurskiy.DTO;
using VladCurskiy.Models;
using VladCurskiy.Tools;

namespace VladCurskiy.ViewModels
{
    public class UserVM
    {    
        public User EditUser { get; set; }
        public CommandVM SaveUser { get; set; }

        private CurrentPageControl currentPageControl;
        public UserVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditUser = new User();
            InitCommand();
        }
        public UserVM(User editUser, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditUser = editUser;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveUser = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (EditUser.ID == 0)
                    model.Insert(EditUser);
                else
                    model.Update(EditUser);
                currentPageControl.Back();
            });
        }
    }
}

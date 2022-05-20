using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VladCurskiy.DTO;
using VladCurskiy.Models;
using VladCurskiy.Pages;
using VladCurskiy.Tools;

namespace VladCurskiy.ViewModels
{
    public class MessageVM : BaseVM
    {
        public Message EditMes { get; }
        public CommandVM SaveMes { get; set; }
        public User SelectedUser
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                Signal();
            }
        }

        public List<User> Users { get; set; }

        private CurrentPageControl currentPageControl;
        private User selectedUser;

        public MessageVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditMes = new Message();
            Init();
        }

        public MessageVM(Message editMess, CurrentPageControl currentPageControl)
        {
            EditMes = editMess;
            this.currentPageControl = currentPageControl;
            Init();
            SelectedUser = Users.FirstOrDefault(s => s.ID == editMess.UserId);
        }

        private void Init()
        {
            Users = SqlModel.GetInstance().UserCreate(0, 100);
            SaveMes = new CommandVM(() => {
                if (SelectedUser == null)
                {
                    System.Windows.MessageBox.Show("Нужно выбрать получателя для продолжения");
                    return;
                }
                EditMes.UserId = SelectedUser.ID;
                var model = SqlModel.GetInstance();
                if (EditMes.ID == 0)
                    model.Insert(EditMes);
                else
                    model.Update(EditMes);
                currentPageControl.SetPage(new ViewMessagePage(SelectedUser));
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VladCurskiy.DTO;
using VladCurskiy.Models;

namespace VladCurskiy.ViewModels
{
    public class ViewMessageVM : BaseVM
    {
        private User selectedUser;
        private List<Message> messageBYUser;

        public List<User> Users { get; set; }
        public User SelectedUser
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                MessageBYUser = SqlModel.GetInstance().MessageBYUser(selectedUser);
                Signal();
            }
        }
        public List<Message> MessageBYUser
        {
            get => messageBYUser;
            set
            {
                messageBYUser = value;
                Signal();
            }
        }
        public Message SelectedMes { get; set; }

        public ViewMessageVM(User selectedUser)
        {
            SqlModel sqlModel = SqlModel.GetInstance();
            Users = sqlModel.UserCreate(0, 100);
            SelectedUser = Users.FirstOrDefault(s => s.ID == selectedUser?.ID);
        }
    }
}

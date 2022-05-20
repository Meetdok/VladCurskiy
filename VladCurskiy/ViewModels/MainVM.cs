using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VladCurskiy.Pages;
using VladCurskiy.Tools;

namespace VladCurskiy.ViewModels
{
    public class MainVM : BaseVM
    {
        CurrentPageControl currentPageControl;


        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }

        public CommandVM Option { get; set; }

        public CommandVM MainMenu { get; set; }

        public CommandVM User { get; set; }

        public CommandVM ViewUser { get; set; }

        public CommandVM Message { get; set; }

        public CommandVM ViewMessage { get; set; }

        public MainVM()
        {
            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;


            User = new CommandVM(() =>
            {
                currentPageControl.SetPage(new UserPage(new UserVM(currentPageControl)));
            });

            Option = new CommandVM(() =>
            {
                currentPageControl.SetPage(new OptionPage(currentPageControl));
            });


            ViewUser = new CommandVM(() =>
            {
                currentPageControl.SetPage(new ViewUserPage(currentPageControl));
            });


            MainMenu = new CommandVM(() => {
                currentPageControl.SetPage(null);
            });


            Message = new CommandVM(() =>
            {
                currentPageControl.SetPage(new MessagePage(new MessageVM(currentPageControl)));
            });

            ViewMessage = new CommandVM(() =>
            {
                currentPageControl.SetPage(new ViewMessagePage(null));

            });

        }


        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }

    }
}

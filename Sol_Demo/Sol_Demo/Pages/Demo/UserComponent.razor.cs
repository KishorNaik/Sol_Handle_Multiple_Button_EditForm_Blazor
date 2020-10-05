using Microsoft.AspNetCore.Components.Forms;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class UserComponent
    {
        #region Constructor

        public UserComponent()
        {
            UserM = new UserModel();
        }

        #endregion Constructor

        #region Private Property

        private UserModel UserM { get; set; }

        private bool IsDisplay { get; set; }

        #endregion Private Property

        #region Protected Event Handler

        protected void OnSubmit(EditContext formContext)
        {
            var flag = formContext?.Validate();
            if (flag == false) return;

            // Do Someting

            // Demo Code
            IsDisplay = true;
        }

        protected void OnDelete(EditContext formContext)
        {
            var flag = formContext?.Validate();
            if (flag == false) return;

            // Do Something

            // Demo Code
            IsDisplay = true;
        }

        protected void OnCancel()
        {
            this.UserM.EmailId = null;
            this.UserM.FullName = null;

            IsDisplay = false;

            // Do Something
        }

        #endregion Protected Event Handler
    }
}
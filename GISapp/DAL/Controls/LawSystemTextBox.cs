using System;

namespace LawSystem.Helper.Controls
{
    public class LawSystemTextBox : System.Web.UI.WebControls.TextBox
    {
        public string OperationName { get; set; }

        protected override void OnInit(EventArgs e)
        {
            this.Enabled = new BLL.BLL_RoleOperations().IsUserHavePermission(int.Parse(Page.User.Identity.Name), OperationName);
            base.OnInit(e);
        }
    }
}

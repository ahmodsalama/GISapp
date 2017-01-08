using System;

namespace LawSystem.Helper.Controls
{
    public class LawSystemHyperLink : System.Web.UI.WebControls.HyperLink
    {
        public string OperationName { get; set; }

        protected override void OnInit(EventArgs e)
        {
            this.Enabled = new BLL.BLL_RoleOperations().IsUserHavePermission(int.Parse(Page.User.Identity.Name), OperationName);
            base.OnInit(e);
        }
    }
}

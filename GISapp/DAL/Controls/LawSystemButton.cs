using System;
using System.Web.UI;

namespace LawSystem.Helper.Controls
{
    public class LawSystemButton: System.Web.UI.WebControls.Button
    {
        public string OperationName { get; set; }

        protected override void OnInit(EventArgs e)
        {
            this.Enabled = new BLL.BLL_RoleOperations().IsUserHavePermission(int.Parse(Page.User.Identity.Name), OperationName);
            base.OnInit(e); 
        }
    }
  

   
}

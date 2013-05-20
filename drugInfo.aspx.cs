using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PHP_Drug_Interaction_UI
{
    public partial class drugInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddDrug_Click(object sender, EventArgs e)
        {
            Session.Add("PopUP_Result","OK");
        }

       
    }
}
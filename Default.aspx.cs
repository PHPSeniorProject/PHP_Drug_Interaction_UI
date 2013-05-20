using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PHP_Drug_Interaction_UI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        public void openPopUP(string URL) 
        {
            ClientScript.RegisterStartupScript(this.GetType(), "newWindow",String.Format(String.Format("<script>window.open('{0}');</script>",URL)));
        }
        protected void txtDrugList_TextChanged(object sender, EventArgs e)
        {
            string comptext = txtDrugList.Text;

            DrugNameCompService service = new DrugNameCompService();

            string drugName = service.getCompletionList(comptext, 3);
            if (drugName != "")
            {
                txtDrugList.Text = drugName;
                openPopUP("drugInfo.aspx");
            }
            else
            {
                txtDrugList.Text = comptext;
            }

            if (Session["PopUP_Result"]=="OK")
            {
                
            }
            
        }
    }
}
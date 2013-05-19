using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PHP_Drug_Interaction_UI
{
    /// <summary>
    /// Summary description for DrugNameCompService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DrugNameCompService : System.Web.Services.WebService
    {
        string[] drugList = { "MAJEZIK", "AFERIN", "COOLKEN" };

        [WebMethod]
        public string getCompletionList(string compText, int compLengt)
        {
            if (compText.Length >= compLengt)
            {
                for (int i = 0; i < drugList.Length; i++)
                {
                    if (drugList[i].Contains(compText.ToUpper()))
                    {
                        return drugList[i];
                    }
                }
            }
            return "";
        }
    }
}

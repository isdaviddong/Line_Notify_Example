using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using isRock.LineNotify; 

namespace Line_Notify_Example
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果從callback.aspx導回此頁，應該可以取得token
            if (!this.IsPostBack)
            {
                //如果有，則保留於text
                //(注意這不安全，應該要保留在後端，此為範例)
                this.txb_token.Value = Request.QueryString["token"];
            }
        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            //透過LineNotSDK中的API，傳送
            var ret = Utility.SendNotify(this.txb_token.Value, this.txb_msg.Value);
            msg.InnerText = $"send '{ this.txb_msg.Value}'..." + ret.message;
        }
    }
}
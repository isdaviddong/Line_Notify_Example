using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using isRock.LineNotify;

namespace Line_Notify_Example
{
    public partial class Callback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //取得返回的code
            var code = Request.QueryString["code"];
            if (code == null)
            {
                Response.Write("沒有正確回應code");
                Response.End();
            }
            //顯示，測試用
            Response.Write("<br/> code : " + code);
            //從Code取回toke
            var token = Utility.GetTokenFromCode(code,
                "uf8x32KjCX假的UwsX83OXNI2",  //TODO:請更正為你自己的 client_id
                "ZeQH6lX!Bv假的O0pq假的x7NYYK4假的XT$lvf7p假的2lyY", //TODO:請更正為你自己的 client_secret
                "http://localhost:3696/Callback.aspx");
            //顯示，測試用
            Response.Write("<br/> token : " + token.access_token);
            //利用token發各測試訊息
            Utility.SendNotify(token.access_token, "msg test - " + System.DateTime.Now.ToString());
            //導入首頁，帶入token
            //(注意這是範例，token不該用明碼傳遞，也不該出現在用戶端，你應該自行記錄在資料庫或ServerSite session中)
            Response.Redirect("default.aspx?token=" + token.access_token);
        }
    }
}
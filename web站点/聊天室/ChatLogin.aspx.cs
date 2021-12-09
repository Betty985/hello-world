using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChatLogin : System.Web.UI.Page
{
    string[,] user = { { "雪球", "000" }, { "川普", "001" }, { "玛卡巴卡", "002" } };
    protected void Page_Load(object sender, EventArgs e)
    {
        txtName.Focus();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        for(int i = 0; i < 3; i++)
        {
            if (txtName.Text == user[i, 0] & txtPassword.Text == user[i, 1])
            {
                Session["user"] = user[i, 0];
                Response.Redirect("Chat.html");
            }
        }
        Response.Write("<script type='text/javascript'>alert('用户名或密码错误！'); window.location='ChatLogin.aspx'</script>");
        //Response.Redirect("ChatLogin.aspx");

    }
}
using System;
using System.Web;
using System.Web.UI;

namespace testC
{
	
	public partial class test2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) {
				Response.Write ("hello mac!");
			}
		}
	}
}


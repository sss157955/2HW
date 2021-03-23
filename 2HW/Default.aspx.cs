using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int N = 12;
            int sum = 0;
            for (int i = 0; i <= N; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    sum = sum + i;

                }
            }
            Response.Write(sum);
        }
    }
}
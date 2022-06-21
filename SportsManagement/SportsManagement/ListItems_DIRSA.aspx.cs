﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsManagement
{
    public partial class ListItems_DIRSA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }
        public void GetData()
        {
            SqlConnection con = new SqlConnection("Data Source=SQL5105.site4now.net;initial catalog=db_a3e957_njdynamic003;User ID=db_a3e957_njdynamic003_admin;Password=VnrVjiet@1234");
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from AvailableItems_DIRSA", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rep.DataSource = dt;
                rep.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
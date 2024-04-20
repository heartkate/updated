using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace puso
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }
        void LoadRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alyssa\documents\visual studio 2012\Projects\puso\puso\App_Data\Database1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd;


            cmd = new SqlCommand("Select * from ORDERS", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alyssa\documents\visual studio 2012\Projects\puso\puso\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();



            SqlCommand cmd = new SqlCommand("INSERT INTO ORDERS(MyOrder,Amount) VALUES (@MyOrder,@Amount)", con);
            cmd.Parameters.AddWithValue("@MyOrder", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Amount", TextBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            Label1.Text = "Save Successfully!";
            LoadRecord();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alyssa\documents\visual studio 2012\Projects\puso\puso\App_Data\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;


            cmd = new SqlCommand("Update ORDERS Set MyOrder = @MyOrder, Amount = @Amount Where Id=@Id", con);
            cmd.Parameters.AddWithValue("MyOrder", TextBox2.Text);


            cmd.Parameters.AddWithValue("Amount", TextBox3.Text);
            cmd.Parameters.AddWithValue("Id", TextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            LoadRecord();
            Label2.Text = "Updated Successfully!";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alyssa\documents\visual studio 2012\Projects\puso\puso\App_Data\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;

            cmd = new SqlCommand("Delete from ORDERS Where Id=@Id", con);
            cmd.Parameters.AddWithValue("Id", TextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            LoadRecord();

            Label2.Text = "Deleted Successfully";
        }
    }
}
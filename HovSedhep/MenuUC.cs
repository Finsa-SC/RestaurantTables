using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HovSedhep.Helper;

namespace HovSedhep
{
    public partial class MenuUC : UserControl
    {
        public MenuUC()
        {
            InitializeComponent();
            load_Category();
            load_Data();
        }

        private void load_Category()
        {
            var dt = DBHelper.ExecuteQuery("select CategoryID, Name from Categories");

            var dr = dt.NewRow();
            dr["CategoryID"] = DBNull.Value;
            dr["Name"] = "All";
            dt.Rows.InsertAt(dr, 0);

            cmbCategory.DataSource = dt;
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "Name";
        }
        private void load_Data()
        {
            string query = @"
                        select 
                            m.MenuItemID as [Menu ID],
                            c.Name,
                            m.Name,
                            m.Price,
                            m.Description
                        from MenuItems m
                        join Categories c on m.CategoryID = c.CategoryID
                        where (@n is Null or m.Name like @n)
                            and (@cid is null or c.CategoryID = @cid)";

            dataGridView1.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@n", "%" + txtName.Text + "%"),
                new SqlParameter("@cid", cmbCategory.SelectedValue)
            );
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            load_Data();
        }
    }
}

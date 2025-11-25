using HovSedhep.Helper;
using HovSedhep.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HovSedhep.DialogTable;

namespace HovSedhep
{
    public partial class TableUC : UserControl
    {
        int tableID;
        public TableUC()
        {
            InitializeComponent();

            load_Table();

            A1.Click += Table_Click;
            A2.Click += Table_Click;
            A3.Click += Table_Click;
            A4.Click += Table_Click;
            B1.Click += Table_Click;
            B2.Click += Table_Click;
            C1.Click += Table_Click;
            C2.Click += Table_Click;
        }


        private void load_Table()
        {
            foreach(Button btn in panel1.Controls.OfType<Button>()) 
            {
                btn.BackColor = SystemColors.Control;
            }
            var i = DBHelper.ExecuteReader("select TableID from Transactions where Status = 'Ongoing'",
                    dr => dr.GetInt32(0)
            );
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                tableID = Convert.ToInt32(btn.Tag.ToString());
                if (i.Contains(tableID))
                {
                    btn.BackColor = Color.Khaki;
                }
            }
        }

        
        private void Table_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tableID = Convert.ToInt32(btn.Tag.ToString());
            string query = @"
                    select 
                        o.EmployeeID,
                        t.CustomerName,
                        tb.Capacity
                    from Orders o
                    join Transactions t on t.TransactionID = o.TransactionID 
                    left join RestaurantTables tb on t.TableID = tb.TableID
                    where t.tableID = @tid and t.Status = 'Ongoing'";

            var data = DBHelper.ExecuteReader(query,
                dr => new TableProperty
                {
                    Waitress = dr.GetInt32(0),
                    CustomerName = dr.GetString(1),
                    maxPax = dr.GetInt32(2)
                }, 
                new SqlParameter("@tid", tableID)
            ).FirstOrDefault();
            string q = "select Capacity from RestaurantTables where TableID = @tid";

            var mode = data!=null? DialogTableMode.Seating : DialogTableMode.Assign;
            using (var frm = new DialogTable(tableID, btn.Name.ToString(), mode, data))
            {
                frm.ShowDialog();
            }
            load_Table();
        }
    }
}

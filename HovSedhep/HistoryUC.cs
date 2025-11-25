using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HovSedhep.Helper;
using Microsoft.Data.SqlClient;

namespace HovSedhep
{
    public partial class HistoryUC : UserControl
    {
        public HistoryUC()
        {
            InitializeComponent();
            load_Table();
            load_Transaction();
        }

        private void load_Table()
        {
            var dt = DBHelper.ExecuteQuery("select TableID, Name from RestaurantTables");

            var dr = dt.NewRow();
            dr["TableID"] = DBNull.Value;
            dr["Name"] = "All";
            dt.Rows.InsertAt(dr, 0);

            cmbTable.DataSource = dt;
            cmbTable.ValueMember = "TableID";
            cmbTable.DisplayMember = "Name";
        }

        private void load_Transaction()
        {
            string query = @"
                    select
                        t.TransactionID as [Transaction ID],
                        rt.Name as [Table Name],
                        t.CustomerName as [Customer Name],
                        format(t.TransactionDate, 'dd MMMM yyyy') as Date,
                        isnull(sum(od.Quantity * od.Price), 0) as [Total Price]
                    from Transactions t
                    join RestaurantTables rt on t.TableID = rt.TableID
                    left join Orders o on t.TransactionID = o.TransactionID
                    left join OrderDetails od on o.OrderID = od.OrderID
                    where 
                        (@tid is null or t.TableID = @tid)
                        and (cast(t.TransactionDate as Date) = cast(@td as Date))
                    group by
                        t.TransactionID,
                        rt.Name,
                        t.CustomerName,
                        t.TransactionDate
                    order by 
                        t.TransactionDate desc";

            dataGridView1.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@tid", cmbTable.SelectedValue == DBNull.Value ? (object)DBNull.Value : cmbTable.SelectedValue),
                new SqlParameter("@td", dteDate.Value)
            );
        }
        private void load_Order(int order)
        {
            string query = @"
                        select
                            t.TransactionID as [Transtaction ID],
                            o.OrderID as [Order ID],
                            format(o.OrderTime, 'HH:mm:ss') as [Order Time],
                            e.Name as [Input By Waitress],
                            sum(do.Quantity) as [Number of Item Ordered]
                        from Transactions t
                        join RestaurantTables rt on t.TableID = rt.TableID
                        left join Orders o on t.TransactionID = o.TransactionID
                        join Employees e on o.EmployeeID = e.EmployeeID
                        left join OrderDetails do on o.OrderID = do.OrderID
                        where
                            t.TransactionID = @tid
                        group by 
                            t.TransactionID,
                            o.OrderID,
                            o.OrderTime,
                            e.Name";

            dataGridView2.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@tid", order)
            );
        }

        private void load_OrderDetail(int od)
        {
            string query = @"
                        select
                            o.OrderID as [Order ID],
                            od.OrderDetailID as [Order Detail ID],
                            m.Name as [Menu Name],
                            od.Quantity,
                            sum(od.Quantity * od.Price) as Price
                        from Orders o
                        join Transactions t on o.TransactionID = t.TransactionID
                        join RestaurantTables rt on t.TableID = rt.TableID
                        left join OrderDetails od on o.OrderID = od.OrderID
                        left join MenuItems m on od.MenuItemID = m.MenuItemID
                        where
                            od.OrderID = @od
                        group by 
                            o.OrderID,
                            od.OrderDetailID,
                            m.Name,
                            od.Quantity
";
            dataGridView3.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@od", od)
            );
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            load_Transaction();
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int tid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                load_Order(tid);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int od = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value);

                load_OrderDetail(od);
            }
        }
    }
}

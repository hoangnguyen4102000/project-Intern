using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace demo
{
    public partial class Form1 : Form
    {
        DataSet data = new DataSet();
        SqlConnection sqlConnection = new SqlConnection();
        int chuot = 0;
        DataSet GetAll()
        {


            //string sql= "select*from Customers";           
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                //SqlCommand cmd = new SqlCommand(sql, connection);          
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select*from Customers select*from Cards", connection);
                //adapter.Fill(data, "Customers");
                adapter.TableMappings.Add("Table", "Customers");
                adapter.TableMappings.Add("Table1", "Cards");
                adapter.Fill(data);
                //this.sfDataGrid1.DataSource = data.Tables["Cards"];
                connection.Close();
                connection.Dispose();

            }
            Console.Read();
            return data;

        }
        //public DataTable customertable = new DataTable();
        //tktapidevEntities1 db = new tktapidevEntities1();
        public Form1()
        {

            InitializeComponent();
            this.sfDataGrid1.AutoGenerateColumns = true;
            //var table = this.GetDataTable();
            this.sfDataGrid1.AllowDeleting = true;
            //sfDataGrid1.DataSource = table;
            sfDataGrid1.SelectionUnit = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            sfDataGrid1.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;
            //btDelete.Click += btDelete_Click;
            this.sfDataGrid1.CellClick += sfDataGrid1_CellClick;
            sfDataGrid1.AutoExpandGroups = true;

        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            string tencongty = txtTenCongTy.Text;
            string diachi = txtDiaChi.Text;
            string taxcode = txtTaxCode.Text;
            string SDT = txtSDT.Text;
            DateTime tu = dtValidFrom.Value;
            DateTime to = dtValidTo.Value;
            string tong = txtSoLuong.Text;
            string tensanpham = txtTenSP.Text;
            string phienban = txtPhienBan.Text;
            //
            string lkey = txtLKey.Text;
            DateTime cd = dtCreateDate.Value;
            string cb = txtCreateBy.Text;
            DateTime rd = dtCreateDate.Value;
            if (KiemTraKhiNhap())
            {
                try
                {
                    customersTableAdapter.Insert(tencongty, diachi, taxcode, SDT, tu, to, tong, tensanpham, phienban, "", "");
                    cardsTableAdapter.InsertQuery(lkey, cd, cb, tu, to, rd);
                    data.Clear();
                    data.Merge(GetAll());
                    //this.customersTableAdapter.Fill(this.tktapidevDataSet.Customers);
                    //sfDataGrid1.DataSource = GetAll().Tables[0];
                    //sfDataGrid1.DataSource = GetAll();




                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            #region

            //DataTable gridDataTable = this.sfDataGrid1.DataSource as DataTable;
            //if (KiemTraKhiNhap())
            //{
            //    try
            //    {

            //        if (gridDataTable == null || this.sfDataGrid1.View == null)
            //            return;

            //        // Creates a new row.
            //        System.Data.DataRow addNewRow = sfDataGrid1.View.AddNew() as System.Data.DataRow;
            //        //System.Data.DataRow addNewRow = sfDataGrid1.View.AddNew() as System.Data.DataRow;

            //        //sfDataGrid1.View.CommitEdit();
            //        sfDataGrid1.View.CommitNew();

            //        // Initialize the values of first row to the newly added row.
            //        addNewRow.SetField(0, gridDataTable.Rows[0][0]);
            //        addNewRow.SetField(1, gridDataTable.Rows[0][1]);
            //        addNewRow.SetField(2, gridDataTable.Rows[0][2]);
            //        addNewRow.SetField(3, gridDataTable.Rows[0][3]);
            //        addNewRow.SetField(4, gridDataTable.Rows[0][4]);
            //        addNewRow.SetField(5, gridDataTable.Rows[0][5]);
            //        addNewRow.SetField(6, gridDataTable.Rows[0][6]);
            //        addNewRow.SetField(7, gridDataTable.Rows[0][7]);
            //        gridDataTable.Rows[0][0] = int.Parse(txtMaKH.Text);
            //        gridDataTable.Rows[0][1] = txtTenCongTy.Text;
            //        gridDataTable.Rows[0][2] = txtDiaChi.Text;
            //        gridDataTable.Rows[0][3] = txtTaxCode.Text;
            //        gridDataTable.Rows[0][4] = int.Parse(txtSDT.Text);
            //        gridDataTable.Rows[0][5] = int.Parse(txtSoLuong.Text);
            //        gridDataTable.Rows[0][6] = dtValidTo.Value;
            //        gridDataTable.Rows[0][7] = dtValidFrom.Value;
            //        MessageBox.Show("Thêm thành công");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAll();
            //this.cardsTableAdapter.Fill(this.tktapidevDataSet.Cards);

            //this.customersTableAdapter.Fill(this.tktapidevDataSet.Customers);
            txtMaKH.Enabled = false;

            customersBindingSource.DataMember = "Customers";
            customersBindingSource.DataSource = data;

            cardsBindingSource.DataMember = "Cards";
            cardsBindingSource.DataSource = data;

            sfDataGrid1.DataSource = customersBindingSource;
            sfDataGrid2.DataSource = cardsBindingSource;

            HiddenColum();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            
            if (sfDataGrid1.CurrentCell == null)
            {
                MessageBox.Show("loi");

            }
            else
            {
                var selectedItem = this.sfDataGrid1.CurrentItem as DataRowView;
                if (selectedItem == null)
                {
                    MessageBox.Show("loi1");
                }
                else
                {
                    var dataRow = (selectedItem as DataRowView).Row;
                    if (dataRow == null)
                    {
                        MessageBox.Show("loi2");
                    }
                    else
                    {
                        var cellValue = dataRow["CustomerId"];
                        if (cellValue == null)
                        {
                            MessageBox.Show("loi3");
                        }
                        else
                        {
                            int makh = (int)cellValue;
                            customersTableAdapter.DeleteQuery(makh);
                            MessageBox.Show("Xóa thành công");
                            data.Clear();

                            data.Merge(GetAll());
                        }
                    }
                }
            }
           
        }

        public DataTable GetDataTable()
        {
            DataTable customertable = new DataTable();

            //customertable.Columns.Add("CustomerId", typeof(int));
            //customertable.Columns.Add("CompanyName", typeof(string));
            //customertable.Columns.Add("Address", typeof(string));
            //customertable.Columns.Add("TaxCode", typeof(string));
            //customertable.Columns.Add("ContactNumber", typeof(int));
            //customertable.Columns.Add("TotalClient", typeof(int));
            //customertable.Columns.Add("ValidFrom", typeof(DateTime));
            //customertable.Columns.Add("ValidTo", typeof(DateTime));

            //customertable.Rows.Add(1001, "ALFKI", "Maria Anders", "Germany", 0909, 10, "2/5/2019", "3/5/2019");
            //customertable.Rows.Add(1002, "ANATR", "Ana Trujilo", "Mexico", 0101, 15, "7/5/2019", "5/6/2019");
            ////customertable.Rows.Add(1003, "ANTON", "Antonio Moreno", "Mexico", 0202, "1/3/2000", "20/5/2015");
            ////customertable.Rows.Add(1004, "AROUT", "Thomas Hardy", "UK", 0303, "25/5/2019", "3/8/2019");
            //customertable.Rows.Add(1005, "BERGS", "Christina Berglund", "Sweden", 0404, 20, "2/5/2019", "3/9/2019");
            ////customertable.Rows.Add(1006, "BLAUS", "Hanna Moos", "Germany", 0105, "20/5/2019", "3/5/2012");
            ////customertable.Rows.Add(1007, "BLONP", "Frederique Citeaux", "France", 0605, "15/5/2019", "3/5/2013");
            //customertable.Rows.Add(1008, "BOLID", "Martin Sommer", "Spain", 0930, 25, "10/5/2019", "3/5/2015");
            //customertable.Rows.Add(1009, "BONAP", "Laurence Lebihan", "France", 0930, 30, "4/5/2019", "3/5/2014");
            //customertable.Rows.Add(1010, "BOTTM", "Elizabeth Lincoln", "Canada", 0949, 35, "3/5/2019", "3/5/2018");

            return customertable;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.sfDataGrid1.Refresh();
            this.sfDataGrid2.Refresh();
            MessageBox.Show("Sửa thành công");

        }

        private void sfDataGrid1_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                var rowColumnIndex = this.sfDataGrid1.TableControl.PointToCellRowColumnIndex(e.MouseEventArgs.Location);              
            }

        }
        public bool KiemTraKhiNhap()
        {//kieu du lieu so nguyen co dấu
            long ketqua;
            string.IsNullOrEmpty(txtTenCongTy.Text);

            if (txtTenCongTy.Text == "" || txtSoLuong.Text == "" || txtDiaChi.Text == "" || txtTaxCode.Text == "" || txtSDT.Text == "" || txtTenSP.Text == "" || txtPhienBan.Text == "" ||txtLKey.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Yêu cầu!");
                return false;
            }
            #region
            //if (txtMaKH.Text=="")
            //{
            //    MessageBox.Show("vui lòng nhập mã khách hàng");
            //    return false;
            //}  
            //else if(txtTenCongTy.Text=="")
            //{
            //    MessageBox.Show("vui lòng nhập tên công ty");
            //    return false;
            //}   
            //else if(txtTaxCode.Text=="")
            //{
            //    MessageBox.Show("vui lòng nhập tax code");
            //    return false;
            //}
            #endregion
            else if (!(long.TryParse(txtSDT.Text, out ketqua)))
            {
                MessageBox.Show("Vui lòng nhập lại SDT ", "Yêu cầu!");
                return false;

            }

            else if (!(long.TryParse(txtSoLuong.Text, out ketqua)))
            {
                MessageBox.Show("Vui lòng nhập lại số lượng  mà bạn muốn", "Yêu cầu!");
                return false;

            }
            else if (ketqua <= 0)
            {
                MessageBox.Show("Hãy kiểm tra dấu âm", "Yêu cầu!");

                return false;

            }
            else if (dtValidFrom.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày đặt không được lớn hơn ngày hiện tại", "Yêu cầu!");

                return false;
            }
            else if (dtValidTo.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày hẹn không được lớn hơn ngày hiện tại", "Yêu cầu!");

                return false;
            }
            else if (txtLKey.Text == sfDataGrid2.Columns["LicenseKey"].ToString())
            {
                MessageBox.Show("Hãy đặt tên Licenkey khác");
                return false;
            }
            else if(dtCreateDate.Value>DateTime.Now)
            {
                MessageBox.Show("Ngày tạo không lớn hơn ngày hiện tại", "Yêu cầu!");

                return false;
            }
            else if (dtRegisterDate.Value>DateTime.Now)
            {
                MessageBox.Show("Ngày hẹn không được lớn hơn ngày hiện tại", "Yêu cầu!");

                return false;
            }

            return true;
        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tktapidevDataSet);

        }
        public void HiddenColum()
        {
            this.sfDataGrid2.Columns["ValidFrom"].Visible = false;
            this.sfDataGrid2.Columns["ValidTo"].Visible = false;
            this.sfDataGrid2.Columns["Note"].Visible = false;
            this.sfDataGrid2.Columns["Status"].Visible = false;
            this.sfDataGrid2.Columns["HDDSerialNumber"].Visible = false;
            this.sfDataGrid2.Columns["ProcessorID"].Visible = false;
            this.sfDataGrid2.Columns["Users"].Visible = false;
            this.sfDataGrid2.Columns["ContactEmail"].Visible = false;
            this.sfDataGrid2.Columns["ContactPhone"].Visible = false;
            this.sfDataGrid2.Columns["ProductName"].Visible = false;
            this.sfDataGrid2.Columns["ProductVersion"].Visible = false;
            this.sfDataGrid2.Columns["ComputerName"].Visible = false;
            this.sfDataGrid2.Columns["PublicIPAddress"].Visible = false;
            this.sfDataGrid2.Columns["MacAddress"].Visible = false;
            this.sfDataGrid2.Columns["TotalInvoice"].Visible = false;
            this.sfDataGrid2.Columns["TotalInvoiceClient"].Visible = false;
            this.sfDataGrid2.Columns["ExpireDays"].Visible = false;
            this.sfDataGrid1.Columns["GUID"].Visible = false;
            this.sfDataGrid1.Columns["TotalInvoice"].Visible = false;
            this.sfDataGrid2.Columns["Customer_CustomerId"].Visible = false;
        }

        private void btDeleteCard_Click(object sender, EventArgs e)
        {
            var selectedItem1 = this.sfDataGrid2.CurrentItem as DataRowView;
            var dataRow1 = (selectedItem1 as DataRowView).Row;
            var cellValue1 = dataRow1["LicenseKey"];

            string lk = (string)cellValue1;
            cardsTableAdapter.DeleteQuery(lk);
            MessageBox.Show("Xóa thành công");
            data.Clear();

            data.Merge(GetAll());
        }
    }
}
   
    


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
using Syncfusion.Windows.Forms.Grid.Grouping;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;


namespace demo
{
    public partial class Form2 : Form
    {
        DataSet data = new DataSet();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand cmd;
        public string cellValue1 = "-1";
        public string cellValue = "-1";

        DataSet GetAll()
        {                    
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                //SqlCommand cmd = new SqlCommand(sql, connection);          
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select*from Customers select*from Cards", connection);                
                adapter.TableMappings.Add("Table", "Customers1");
                adapter.TableMappings.Add("Table1", "Cards1");
                adapter.Fill(data);
               
                //this.sfDataGrid1.DataSource = data.Tables["Cards"];
                connection.Close();
                connection.Dispose();

            }
            Console.Read();
            return data;
        }
            public Form2()
        {
            InitializeComponent();

            this.gridGroupingControl1.TableOptions.AllowSortColumns = true;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            //GetAll();
            //this.cardsTableAdapter.Fill(this.tktapidevDataSet.Cards);

            //this.customersTableAdapter.Fill(this.tktapidevDataSet.Customers);

            btSave.Enabled = false;
            btDelete.Enabled = false;
            btDeleteCard.Enabled = false;

            customers1BindingSource.DataMember = "Customers1";
            customers1BindingSource.DataSource =tktapidevDataSet;

            cards1BindingSource.DataMember = "Customers1_Cards1";
            cards1BindingSource.DataSource = customers1BindingSource;
            //cards1BindingSource.DataMember = "Cards1";
            //cards1BindingSource.DataSource = tktapidevDataSet;

            gridGroupingControl1.DataSource = customers1BindingSource;
            gridGroupingControl2.DataSource = cards1BindingSource;
            HiddenColum();
            //gridGroupingControl1.TableControlCurrentCellKeyDown += gridGroupingControl1_TableControlCurrentCellKeyDown;
            //this.gridGroupingControl1.TableOptions.AllowSortColumns = false;
            //this.gridGroupingControl1.TableDescriptor.Columns[3].AllowFilter = false;

            ////Record record = this.gridGroupingControl1.Table.CurrentRecord;
            ////MessageBox.Show("the eqwewq:" + record.Id.ToString());
            //this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.Row;


            tktapidevDataSet.Clear();
            tktapidevDataSet.Merge(GetAll());
            tktapidevDataSet.AcceptChanges();

            // Shows the record navigation bar.
            this.gridGroupingControl1.ShowNavigationBar = true;

            // Show tooltips when the user hovers the mouse over the elements of the RecordNavigationBar.
            this.gridGroupingControl1.ShowNavigationBarToolTips = true;

        }
        
        private void gridGroupingControl1_TableControlCellClick(object sender, GridTableControlCellClickEventArgs e)
        {
            
            btSave.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = true;
            btDeleteCard.Enabled = false;
            txtCustomerUD.Enabled = false;
            binding();
            var s = this.gridGroupingControl1.Table.SelectedRecords;
            GridRangeInfoList s1 = this.gridGroupingControl1.TableModel.Selections.GetSelectedRows(true, true);
            
            foreach (GridRangeInfo info in s1)
            {
                
                {
                    Element el = this.gridGroupingControl1.TableModel.GetDisplayElementAt(info.Top);
                    if (el.GetRecord().GetValue("CustomerId") == null)
                    {
                        
                    }
                    else
                    {
                        cellValue = el.GetRecord().GetValue("CustomerId").ToString();
                    }    
                    
                }
            }            
        }

        private void gridGroupingControl2_TableControlCellClick(object sender, GridTableControlCellClickEventArgs e)
        {
            btSave.Enabled = true;
            btInsert.Enabled = false;
            btDeleteCard.Enabled = true;
            btDelete.Enabled = false;
            txtCustomerUD.Enabled = false;
            binding();
            var x = this.gridGroupingControl2.Table.SelectedRecords;
            GridRangeInfoList s2 = this.gridGroupingControl2.TableModel.Selections.GetSelectedRows(true, true);

            foreach (GridRangeInfo infom in s2)
            {
                Element ele = this.gridGroupingControl2.TableModel.GetDisplayElementAt(infom.Top);
                if (ele.GetRecord().GetValue("CardId") == null)
                { }
                else
                    cellValue1 = ele.GetRecord().GetValue("CardId").ToString();               
            }

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
            string lk = txtLicenseKey.Text;
            DateTime cd = dtCreateDate.Value;
            string cb = txtCreateBy.Text;
            DateTime rd = dtCreateDate.Value;
            string ud = txtCustomerUD.Text;
            if (KiemTraKhiNhap())
            {
                try
                {
                    if (KiemTraCustomerUD())
                    {                       
                        MessageBox.Show("Mã UD đã có! Vui lòng chọn mã khác");
                    }
                    else if(KiemTraLicenseKey())
                    {
                        MessageBox.Show("Mã LicenseKey đã có! Vui lòng chọn mã khác");
                    }    
                    else
                    {
                        customers1TableAdapter.Insert(tencongty, diachi, taxcode, SDT, tu, to, tong, tensanpham, phienban, "", "", ud);

                        cards1TableAdapter.InsertQuery(lk, cd, cb,rd,ud);
                        MessageBox.Show("Thêm thành công");
                        gridGroupingControl1.DataSource = GetAll().Tables[0];
                        
                        data.Clear();
                        //data.Merge(GetAll());
                        data.AcceptChanges();
                        
                        //gridGroupingControl1.Table.Reload();
                        //gridGroupingControl1.Refresh();


                        //cards1TableAdapter.Update(this.tktapidevDataSet.Cards1);
                        //gridGroupingControl2.Table.Reload();
                        //tktapidevDataSet.Cards1.Clear();
                        //tktapidevDataSet.Merge(GetAll());
                        //tktapidevDataSet.Cards1.AcceptChanges();
                        //gridGroupingControl2.Table.Reload();
                        //gridGroupingControl2.Table.Reload();
                        //gridGroupingControl2.Refresh();

                        Form2_Load(sender, e);
                    }
                    
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        public bool KiemTraKhiNhap()
        {
            long ketqua;
            string.IsNullOrEmpty(txtTenCongTy.Text);

            if (txtTenCongTy.Text == "" || txtSoLuong.Text == "" || txtDiaChi.Text == "" || txtTaxCode.Text == "" || txtSDT.Text == "" || txtTenSP.Text == "" || txtPhienBan.Text == ""||txtCreateBy.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Yêu cầu!");
                return false;
            }

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

            else if (dtCreateDate.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày tạo không lớn hơn ngày hiện tại", "Yêu cầu!");

                return false;
            }
            else if (dtRegisterDate.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày hẹn không được lớn hơn ngày hiện tại", "Yêu cầu!");

                return false;
            }

            return true;
        }
        public void HiddenColum()
        {
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ValidFrom");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ValidTo");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("Note");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("Status");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ProcessorID");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("HDDSerialNumber");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ContactEmail");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ContactPhone");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ProductName");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ProductVersion");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ComputerName");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("PublicIPAddress");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("MacAddress");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("TotalInvoice");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("TotalInvoiceClient");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("ExpireDays");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("GUID");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("TotalInvoice");
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("Customer_CustomerId");
           
            this.gridGroupingControl2.TableDescriptor.VisibleColumns.Remove("Users");

        }

        private void btDeleteCard_Click(object sender, EventArgs e)
        {
            try
            {
                cards1TableAdapter.DeleteQuery(int.Parse(cellValue1));
                Record currentRecord2 = this.gridGroupingControl2.Table.CurrentRecord;
                currentRecord2.Delete();
                this.gridGroupingControl2.Refresh();
                gridGroupingControl2.DataSource = cards1BindingSource;

                MessageBox.Show("Xóa thành công");
                data.Clear();
                data.Merge(GetAll());
                                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {            
            string lk = txtLicenseKey.Text;
            DateTime cd = dtCreateDate.Value;
            string cb = txtCreateBy.Text;
            DateTime rd = dtCreateDate.Value;
            string ud = txtCustomerUD.Text;
            if (KiemTraLicenseKey())
            {
                MessageBox.Show(cellValue1);

                this.Validate();
                this.customers1BindingSource.EndEdit();
                this.cards1BindingSource.EndEdit();
                this.customers1TableAdapter.Update(this.tktapidevDataSet.Customers1);
                this.cards1TableAdapter.Update(this.tktapidevDataSet.Cards1);
                MessageBox.Show("Update successful");
            }
            else
            {
                cards1TableAdapter.InsertQuery(lk, cd, cb, rd, ud);
                MessageBox.Show("Thêm thành công");

                btSave.Enabled = true;
                this.gridGroupingControl2.Table.Records.DeleteAll();
                gridGroupingControl2.DataSource = cards1BindingSource;
            }
            tktapidevDataSet.Merge(GetAll());
        }

        private void btDelete_Click(object sender, EventArgs e)
        {         
            customers1TableAdapter.DeleteQuery(int.Parse(cellValue));           
            Record currentRecord = this.gridGroupingControl1.Table.CurrentRecord;
            currentRecord.Delete();
            this.gridGroupingControl1.Refresh();
            gridGroupingControl1.DataSource = customers1BindingSource;

            MessageBox.Show("Xóa thành công");
            data.Clear();
            data.Merge(GetAll());
        }
        
        private void gridGroupingControl1_TableControlCurrentCellKeyDown(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlKeyEventArgs e)
        {
            
            
            if (e.Inner.KeyData == Keys.Delete && e.TableControl.Table.CurrentRecord != null)
            {
                

                var s = this.gridGroupingControl1.Table.SelectedRecords;
                GridRangeInfoList s1 = this.gridGroupingControl1.TableModel.Selections.GetSelectedRows(true, true);

                foreach (GridRangeInfo info in s1)
                {

                    Element el = this.gridGroupingControl1.TableModel.GetDisplayElementAt(info.Top);
                    cellValue = el.GetRecord().GetValue("CustomerId").ToString();
                    customers1TableAdapter.DeleteQuery(int.Parse(cellValue));
                    Record currentRecord = this.gridGroupingControl1.Table.CurrentRecord;
                    currentRecord.Delete();
                    
                }
                data.Clear();
                data.Merge(GetAll());
                MessageBox.Show("Xóa thành công");
            }

                //gridGroupingControl1.Table.DeleteRecord(currentRecord);

                
        }

        private void gridGroupingControl2_TableControlCurrentCellKeyDown(object sender, GridTableControlKeyEventArgs e)
        {
            if (e.Inner.KeyData == Keys.Delete && e.TableControl.Table.CurrentRecord != null)
            {


                var x = this.gridGroupingControl2.Table.SelectedRecords;
                GridRangeInfoList s2 = this.gridGroupingControl2.TableModel.Selections.GetSelectedRows(true, true);

                foreach (GridRangeInfo info in s2)
                {

                    Element ele = this.gridGroupingControl2.TableModel.GetDisplayElementAt(info.Top);
                    cellValue1 = ele.GetRecord().GetValue("CardId").ToString();
                    cards1TableAdapter.DeleteQuery(int.Parse(cellValue1));
                    Record currentRecord = this.gridGroupingControl2.Table.CurrentRecord;
                    currentRecord.Delete();

                }
                data.Clear();
                data.Merge(GetAll());
                MessageBox.Show("Xóa thành công");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btInsert.Enabled = true;
            txtCustomerUD.Enabled = true;
            txtCustomerUD.Focus();
            txtCustomerUD.Clear();                   
            txtTenCongTy.Clear();
            txtDiaChi.Clear();
            txtTaxCode.Clear();
            txtSDT.Clear();
            dtValidFrom.Refresh();
            dtValidTo.Refresh();
            txtSoLuong.Clear();
            txtTenSP.Clear();
            txtPhienBan.Clear();
            txtLicenseKey.Clear();
            dtCreateDate.Refresh();
            txtCreateBy.Clear();
            dtRegisterDate.Refresh();
        }
        private bool KiemTraCustomerUD()
        {
            bool tatkt = false;
            string ud=txtCustomerUD.Text;
            
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            connection.Open();

            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from Cards where CustomerUD ='" + ud + "'", connection);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);

            if (dt_kiemtra.Rows.Count > 0)
            {
                tatkt = true;
            }
            da_kiemtra.Dispose();
            return tatkt;
        }
        public void binding()
        {
            txtCustomerUD.Enabled = false;
            txtCustomerUD.DataBindings.Clear();
            txtCustomerUD.DataBindings.Add("text", gridGroupingControl1.DataSource, "CustomerUD");

            txtCustomerUD.DataBindings.Clear();
            txtCustomerUD.DataBindings.Add("text", gridGroupingControl2.DataSource, "CustomerUD");

            txtTenCongTy.DataBindings.Clear();
            txtTenCongTy.DataBindings.Add("text", gridGroupingControl1.DataSource, "CompanyName");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", gridGroupingControl1.DataSource, "Address");

            txtTaxCode.DataBindings.Clear();
            txtTaxCode.DataBindings.Add("text", gridGroupingControl1.DataSource, "TaxCode");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", gridGroupingControl1.DataSource, "ContractNumber");

            dtValidFrom.DataBindings.Clear();
            dtValidFrom.DataBindings.Add("text", gridGroupingControl1.DataSource, "ValidFrom");

            dtValidTo.DataBindings.Clear();
            dtValidTo.DataBindings.Add("text", gridGroupingControl1.DataSource, "ValidTo");
          
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("text", gridGroupingControl1.DataSource, "TotalClients");

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("text", gridGroupingControl1.DataSource, "ProductName");
       
            txtPhienBan.DataBindings.Clear();
            txtPhienBan.DataBindings.Add("text", gridGroupingControl1.DataSource, "ProductVersion");
        
            txtLicenseKey.DataBindings.Clear();
            txtLicenseKey.DataBindings.Add("text", gridGroupingControl2.DataSource, "LicenseKey");

            dtCreateDate.DataBindings.Clear();
            dtCreateDate.DataBindings.Add("text", gridGroupingControl2.DataSource, "CreatedDate");

            txtCreateBy.DataBindings.Clear();
            txtCreateBy.DataBindings.Add("text", gridGroupingControl2.DataSource, "CreatedBy");

            dtRegisterDate.DataBindings.Clear();
            dtRegisterDate.DataBindings.Add("text", gridGroupingControl2.DataSource, "RegisterDate");
        }
      
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private bool KiemTraLicenseKey()
        {
            bool tatkt = false;
            string lk = txtLicenseKey.Text;
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            connection.Open();

            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from Cards where LicenseKey ='" + lk + "'", connection);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);

            if (dt_kiemtra.Rows.Count > 0) 
            {
                tatkt = true;
            }
            
            da_kiemtra.Dispose();
            return tatkt;          
        }      
    }
    
}

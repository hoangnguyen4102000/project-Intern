
namespace demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhienBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreateBy = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtValidFrom = new System.Windows.Forms.DateTimePicker();
            this.dtValidTo = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDataGrid2 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tktapidevDataSet = new demo.tktapidevDataSet();
            this.customersTableAdapter = new demo.tktapidevDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new demo.tktapidevDataSetTableAdapters.TableAdapterManager();
            this.cardsTableAdapter = new demo.tktapidevDataSetTableAdapters.CardsTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLKey = new System.Windows.Forms.TextBox();
            this.btDeleteCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktapidevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(134, 25);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "CustomerId";
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(134, 60);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(200, 20);
            this.txtTenCongTy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "CompanyName";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(625, 22);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(201, 20);
            this.txtTenSP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProductName";
            // 
            // txtPhienBan
            // 
            this.txtPhienBan.Location = new System.Drawing.Point(625, 48);
            this.txtPhienBan.Name = "txtPhienBan";
            this.txtPhienBan.Size = new System.Drawing.Size(201, 20);
            this.txtPhienBan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "ProductVersion";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "CreatedDate";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "CreatedBy";
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.Location = new System.Drawing.Point(626, 96);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.Size = new System.Drawing.Size(200, 20);
            this.dtCreateDate.TabIndex = 3;
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.Location = new System.Drawing.Point(625, 131);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.Size = new System.Drawing.Size(201, 20);
            this.txtCreateBy.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(539, 221);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(80, 66);
            this.btInsert.TabIndex = 4;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(134, 101);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "ContactNumber";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "ValidFrom";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "ValidTo";
            // 
            // dtValidFrom
            // 
            this.dtValidFrom.Location = new System.Drawing.Point(134, 235);
            this.dtValidFrom.Name = "dtValidFrom";
            this.dtValidFrom.Size = new System.Drawing.Size(200, 20);
            this.dtValidFrom.TabIndex = 3;
            // 
            // dtValidTo
            // 
            this.dtValidTo.Location = new System.Drawing.Point(134, 267);
            this.dtValidTo.Name = "dtValidTo";
            this.dtValidTo.Size = new System.Drawing.Size(200, 20);
            this.dtValidTo.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(503, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "RegisterDate";
            // 
            // dtRegisterDate
            // 
            this.dtRegisterDate.Location = new System.Drawing.Point(625, 171);
            this.dtRegisterDate.Name = "dtRegisterDate";
            this.dtRegisterDate.Size = new System.Drawing.Size(200, 20);
            this.dtRegisterDate.TabIndex = 3;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(134, 131);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(200, 20);
            this.txtTaxCode.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "TaxCode";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(134, 168);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(134, 202);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 20);
            this.txtSoLuong.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "TotalClients";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(700, 221);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(80, 66);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete Customer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(1046, 221);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(80, 66);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Location = new System.Drawing.Point(-8, 291);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(834, 403);
            this.sfDataGrid1.TabIndex = 5;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.sfDataGrid1_CellClick);
            // 
            // sfDataGrid2
            // 
            this.sfDataGrid2.AccessibleName = "Table";
            this.sfDataGrid2.Location = new System.Drawing.Point(832, 293);
            this.sfDataGrid2.Name = "sfDataGrid2";
            this.sfDataGrid2.Size = new System.Drawing.Size(397, 401);
            this.sfDataGrid2.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.sfDataGrid2.TabIndex = 6;
            this.sfDataGrid2.Text = "sfDataGrid2";
            // 
            // tktapidevDataSet
            // 
            this.tktapidevDataSet.DataSetName = "tktapidevDataSet";
            this.tktapidevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = this.cardsTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = demo.tktapidevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cardsTableAdapter
            // 
            this.cardsTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(503, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "LicenseKey";
            // 
            // txtLKey
            // 
            this.txtLKey.Location = new System.Drawing.Point(625, 68);
            this.txtLKey.Name = "txtLKey";
            this.txtLKey.Size = new System.Drawing.Size(201, 20);
            this.txtLKey.TabIndex = 1;
            // 
            // btDeleteCard
            // 
            this.btDeleteCard.Location = new System.Drawing.Point(887, 221);
            this.btDeleteCard.Name = "btDeleteCard";
            this.btDeleteCard.Size = new System.Drawing.Size(74, 66);
            this.btDeleteCard.TabIndex = 7;
            this.btDeleteCard.Text = "DeleteCard";
            this.btDeleteCard.UseVisualStyleBackColor = true;
            this.btDeleteCard.Click += new System.EventHandler(this.btDeleteCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1196, 706);
            this.Controls.Add(this.btDeleteCard);
            this.Controls.Add(this.sfDataGrid2);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.dtValidFrom);
            this.Controls.Add(this.dtValidTo);
            this.Controls.Add(this.dtRegisterDate);
            this.Controls.Add(this.dtCreateDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreateBy);
            this.Controls.Add(this.txtLKey);
            this.Controls.Add(this.txtPhienBan);
            this.Controls.Add(this.txtTenCongTy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKH);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktapidevDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhienBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtCreateDate;
        private System.Windows.Forms.TextBox txtCreateBy;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtValidFrom;
        private System.Windows.Forms.DateTimePicker dtValidTo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtRegisterDate;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private tktapidevDataSet tktapidevDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private tktapidevDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private tktapidevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private tktapidevDataSetTableAdapters.CardsTableAdapter cardsTableAdapter;
        private System.Windows.Forms.BindingSource cardsBindingSource;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLKey;
        private System.Windows.Forms.Button btDeleteCard;
    }
}


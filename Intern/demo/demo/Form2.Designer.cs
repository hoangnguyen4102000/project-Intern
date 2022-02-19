
namespace demo
{
    partial class Form2
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
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.gridGroupingControl2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.tktapidevDataSet = new demo.tktapidevDataSet();
            this.cards1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cards1TableAdapter = new demo.tktapidevDataSetTableAdapters.Cards1TableAdapter();
            this.tableAdapterManager = new demo.tktapidevDataSetTableAdapters.TableAdapterManager();
            this.customers1TableAdapter = new demo.tktapidevDataSetTableAdapters.Customers1TableAdapter();
            this.btDeleteCard = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.dtValidFrom = new System.Windows.Forms.DateTimePicker();
            this.dtValidTo = new System.Windows.Forms.DateTimePicker();
            this.dtRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.dtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateBy = new System.Windows.Forms.TextBox();
            this.txtPhienBan = new System.Windows.Forms.TextBox();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lb14 = new System.Windows.Forms.Label();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerUD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktapidevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cards1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Location = new System.Drawing.Point(-2, 273);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(792, 296);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.VersionInfo = "19.4460.0.48";
            this.gridGroupingControl1.TableControlCurrentCellKeyDown += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlKeyEventHandler(this.gridGroupingControl1_TableControlCurrentCellKeyDown);
            this.gridGroupingControl1.TableControlCellClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.gridGroupingControl1_TableControlCellClick);
            // 
            // gridGroupingControl2
            // 
            this.gridGroupingControl2.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridGroupingControl2.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl2.Location = new System.Drawing.Point(796, 273);
            this.gridGroupingControl2.Name = "gridGroupingControl2";
            this.gridGroupingControl2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl2.Size = new System.Drawing.Size(403, 296);
            this.gridGroupingControl2.TabIndex = 1;
            this.gridGroupingControl2.Text = "gridGroupingControl2";
            this.gridGroupingControl2.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl2.VersionInfo = "19.4460.0.48";
            this.gridGroupingControl2.TableControlCurrentCellKeyDown += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlKeyEventHandler(this.gridGroupingControl2_TableControlCurrentCellKeyDown);
            this.gridGroupingControl2.TableControlCellClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.gridGroupingControl2_TableControlCellClick);
            // 
            // tktapidevDataSet
            // 
            this.tktapidevDataSet.DataSetName = "tktapidevDataSet";
            this.tktapidevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cards1BindingSource
            // 
            this.cards1BindingSource.DataMember = "Customers1_Cards1";
            this.cards1BindingSource.DataSource = this.customers1BindingSource;
            // 
            // customers1BindingSource
            // 
            this.customers1BindingSource.DataMember = "Customers1";
            this.customers1BindingSource.DataSource = this.tktapidevDataSet;
            // 
            // cards1TableAdapter
            // 
            this.cards1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cards1TableAdapter = this.cards1TableAdapter;
            this.tableAdapterManager.CardsTableAdapter = null;
            this.tableAdapterManager.Customers1TableAdapter = this.customers1TableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo.tktapidevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customers1TableAdapter
            // 
            this.customers1TableAdapter.ClearBeforeFill = true;
            // 
            // btDeleteCard
            // 
            this.btDeleteCard.Location = new System.Drawing.Point(840, 199);
            this.btDeleteCard.Name = "btDeleteCard";
            this.btDeleteCard.Size = new System.Drawing.Size(74, 66);
            this.btDeleteCard.TabIndex = 39;
            this.btDeleteCard.Text = "DeleteCard";
            this.btDeleteCard.UseVisualStyleBackColor = true;
            this.btDeleteCard.Click += new System.EventHandler(this.btDeleteCard_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(993, 199);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(80, 66);
            this.btSave.TabIndex = 38;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(665, 199);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(80, 66);
            this.btDelete.TabIndex = 37;
            this.btDelete.Text = "Delete Customer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(531, 199);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(80, 66);
            this.btInsert.TabIndex = 36;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // dtValidFrom
            // 
            this.dtValidFrom.Location = new System.Drawing.Point(126, 213);
            this.dtValidFrom.Name = "dtValidFrom";
            this.dtValidFrom.Size = new System.Drawing.Size(200, 20);
            this.dtValidFrom.TabIndex = 35;
            // 
            // dtValidTo
            // 
            this.dtValidTo.Location = new System.Drawing.Point(126, 245);
            this.dtValidTo.Name = "dtValidTo";
            this.dtValidTo.Size = new System.Drawing.Size(200, 20);
            this.dtValidTo.TabIndex = 34;
            // 
            // dtRegisterDate
            // 
            this.dtRegisterDate.Location = new System.Drawing.Point(617, 141);
            this.dtRegisterDate.Name = "dtRegisterDate";
            this.dtRegisterDate.Size = new System.Drawing.Size(200, 20);
            this.dtRegisterDate.TabIndex = 33;
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.Location = new System.Drawing.Point(619, 82);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.Size = new System.Drawing.Size(200, 20);
            this.dtCreateDate.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "ProductVersion";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(495, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "RegisterDate";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "CreatedBy";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "ValidTo";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "TotalClients";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "ContactNumber";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "CompanyName";
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.Location = new System.Drawing.Point(619, 109);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.Size = new System.Drawing.Size(201, 20);
            this.txtCreateBy.TabIndex = 17;
            // 
            // txtPhienBan
            // 
            this.txtPhienBan.Location = new System.Drawing.Point(617, 26);
            this.txtPhienBan.Name = "txtPhienBan";
            this.txtPhienBan.Size = new System.Drawing.Size(201, 20);
            this.txtPhienBan.TabIndex = 15;
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(126, 38);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(200, 20);
            this.txtTenCongTy.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "ProductName";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(617, 0);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(201, 20);
            this.txtTenSP.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "CreatedDate";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "ValidFrom";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(126, 180);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 20);
            this.txtSoLuong.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "TaxCode";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(126, 146);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 20);
            this.txtSDT.TabIndex = 11;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(126, 109);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(200, 20);
            this.txtTaxCode.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(126, 79);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // lb14
            // 
            this.lb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb14.Location = new System.Drawing.Point(495, 49);
            this.lb14.Name = "lb14";
            this.lb14.Size = new System.Drawing.Size(116, 23);
            this.lb14.TabIndex = 29;
            this.lb14.Text = "LicenseKey";
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Location = new System.Drawing.Point(618, 56);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(201, 20);
            this.txtLicenseKey.TabIndex = 15;
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 66);
            this.button1.TabIndex = 40;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerUD
            // 
            this.txtCustomerUD.Location = new System.Drawing.Point(126, 3);
            this.txtCustomerUD.Name = "txtCustomerUD";
            this.txtCustomerUD.Size = new System.Drawing.Size(201, 20);
            this.txtCustomerUD.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 22;
            this.label14.Text = "CustomerUD";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(1101, 199);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(81, 66);
            this.btClose.TabIndex = 41;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 567);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDeleteCard);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.dtValidFrom);
            this.Controls.Add(this.dtValidTo);
            this.Controls.Add(this.dtRegisterDate);
            this.Controls.Add(this.dtCreateDate);
            this.Controls.Add(this.lb14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreateBy);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.txtPhienBan);
            this.Controls.Add(this.txtTenCongTy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCustomerUD);
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
            this.Controls.Add(this.gridGroupingControl2);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tktapidevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cards1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl2;
        private tktapidevDataSet tktapidevDataSet;
        private System.Windows.Forms.BindingSource cards1BindingSource;
        private tktapidevDataSetTableAdapters.Cards1TableAdapter cards1TableAdapter;
        private tktapidevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private tktapidevDataSetTableAdapters.Customers1TableAdapter customers1TableAdapter;
        private System.Windows.Forms.BindingSource customers1BindingSource;
        private System.Windows.Forms.Button btDeleteCard;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.DateTimePicker dtValidFrom;
        private System.Windows.Forms.DateTimePicker dtValidTo;
        private System.Windows.Forms.DateTimePicker dtRegisterDate;
        private System.Windows.Forms.DateTimePicker dtCreateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreateBy;
        private System.Windows.Forms.TextBox txtPhienBan;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lb14;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCustomerUD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btClose;
    }
}
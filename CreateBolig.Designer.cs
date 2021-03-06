
namespace RealBolig
{
    partial class CreateBolig
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBoligTabel = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabKundeTabel = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelKiD = new System.Windows.Forms.Label();
            this.mKiDTextbox = new System.Windows.Forms.MaskedTextBox();
            this.mPostNRTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelPostNR = new System.Windows.Forms.Label();
            this.mAdresseTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.mOmrådeTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelOmråde = new System.Windows.Forms.Label();
            this.mKvmTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelKvm = new System.Windows.Forms.Label();
            this.mSalgsPrisTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelSalgsPris = new System.Windows.Forms.Label();
            this.btnForslåPris = new System.Windows.Forms.Button();
            this.btnOpretBolig = new System.Windows.Forms.Button();
            this.kaspermark_dk_db_realboligDataSet2 = new RealBolig.kaspermark_dk_db_realboligDataSet2();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet2TableAdapters.BoligTableAdapter();
            this.biDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.områdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaspermark_dk_db_realboligDataSet = new RealBolig.kaspermark_dk_db_realboligDataSet();
            this.kaspermarkdkdbrealboligDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter();
            this.kiDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuldeNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabBoligTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabKundeTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermarkdkdbrealboligDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBoligTabel);
            this.tabControl1.Controls.Add(this.tabKundeTabel);
            this.tabControl1.Location = new System.Drawing.Point(533, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBoligTabel
            // 
            this.tabBoligTabel.Controls.Add(this.dataGridView1);
            this.tabBoligTabel.Location = new System.Drawing.Point(4, 22);
            this.tabBoligTabel.Name = "tabBoligTabel";
            this.tabBoligTabel.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoligTabel.Size = new System.Drawing.Size(856, 604);
            this.tabBoligTabel.TabIndex = 0;
            this.tabBoligTabel.Text = "Bolig Tabel";
            this.tabBoligTabel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biDDataGridViewTextBoxColumn,
            this.kiDDataGridViewTextBoxColumn,
            this.postNRDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.områdeDataGridViewTextBoxColumn,
            this.salgsPrisDataGridViewTextBoxColumn,
            this.salgsDatoDataGridViewTextBoxColumn,
            this.kvmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boligBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 598);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabKundeTabel
            // 
            this.tabKundeTabel.Controls.Add(this.dataGridView2);
            this.tabKundeTabel.Location = new System.Drawing.Point(4, 22);
            this.tabKundeTabel.Name = "tabKundeTabel";
            this.tabKundeTabel.Padding = new System.Windows.Forms.Padding(3);
            this.tabKundeTabel.Size = new System.Drawing.Size(856, 604);
            this.tabKundeTabel.TabIndex = 1;
            this.tabKundeTabel.Text = "Kunde Tabel";
            this.tabKundeTabel.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kiDDataGridViewTextBoxColumn1,
            this.fuldeNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.kundeBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(850, 598);
            this.dataGridView2.TabIndex = 0;
            // 
            // labelKiD
            // 
            this.labelKiD.AutoSize = true;
            this.labelKiD.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKiD.Location = new System.Drawing.Point(34, 66);
            this.labelKiD.Name = "labelKiD";
            this.labelKiD.Size = new System.Drawing.Size(104, 26);
            this.labelKiD.TabIndex = 1;
            this.labelKiD.Text = "Kunde ID";
            // 
            // mKiDTextbox
            // 
            this.mKiDTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKiDTextbox.Location = new System.Drawing.Point(148, 66);
            this.mKiDTextbox.Name = "mKiDTextbox";
            this.mKiDTextbox.Size = new System.Drawing.Size(330, 30);
            this.mKiDTextbox.TabIndex = 2;
            // 
            // mPostNRTextbox
            // 
            this.mPostNRTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPostNRTextbox.Location = new System.Drawing.Point(148, 117);
            this.mPostNRTextbox.Name = "mPostNRTextbox";
            this.mPostNRTextbox.Size = new System.Drawing.Size(330, 30);
            this.mPostNRTextbox.TabIndex = 4;
            // 
            // labelPostNR
            // 
            this.labelPostNR.AutoSize = true;
            this.labelPostNR.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostNR.Location = new System.Drawing.Point(52, 117);
            this.labelPostNR.Name = "labelPostNR";
            this.labelPostNR.Size = new System.Drawing.Size(86, 26);
            this.labelPostNR.TabIndex = 3;
            this.labelPostNR.Text = "Post nr.";
            // 
            // mAdresseTextbox
            // 
            this.mAdresseTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAdresseTextbox.Location = new System.Drawing.Point(148, 170);
            this.mAdresseTextbox.Name = "mAdresseTextbox";
            this.mAdresseTextbox.Size = new System.Drawing.Size(330, 30);
            this.mAdresseTextbox.TabIndex = 6;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(47, 170);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(91, 26);
            this.labelAdresse.TabIndex = 5;
            this.labelAdresse.Text = "Adresse";
            // 
            // mOmrådeTextbox
            // 
            this.mOmrådeTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mOmrådeTextbox.Location = new System.Drawing.Point(148, 226);
            this.mOmrådeTextbox.Name = "mOmrådeTextbox";
            this.mOmrådeTextbox.Size = new System.Drawing.Size(330, 30);
            this.mOmrådeTextbox.TabIndex = 8;
            // 
            // labelOmråde
            // 
            this.labelOmråde.AutoSize = true;
            this.labelOmråde.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOmråde.Location = new System.Drawing.Point(46, 226);
            this.labelOmråde.Name = "labelOmråde";
            this.labelOmråde.Size = new System.Drawing.Size(92, 26);
            this.labelOmråde.TabIndex = 7;
            this.labelOmråde.Text = "Område";
            // 
            // mKvmTextbox
            // 
            this.mKvmTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKvmTextbox.Location = new System.Drawing.Point(148, 285);
            this.mKvmTextbox.Name = "mKvmTextbox";
            this.mKvmTextbox.Size = new System.Drawing.Size(330, 30);
            this.mKvmTextbox.TabIndex = 10;
            // 
            // labelKvm
            // 
            this.labelKvm.AutoSize = true;
            this.labelKvm.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKvm.Location = new System.Drawing.Point(82, 285);
            this.labelKvm.Name = "labelKvm";
            this.labelKvm.Size = new System.Drawing.Size(56, 26);
            this.labelKvm.TabIndex = 9;
            this.labelKvm.Text = "Kvm";
            // 
            // mSalgsPrisTextbox
            // 
            this.mSalgsPrisTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSalgsPrisTextbox.Location = new System.Drawing.Point(148, 402);
            this.mSalgsPrisTextbox.Name = "mSalgsPrisTextbox";
            this.mSalgsPrisTextbox.Size = new System.Drawing.Size(330, 30);
            this.mSalgsPrisTextbox.TabIndex = 12;
            // 
            // labelSalgsPris
            // 
            this.labelSalgsPris.AutoSize = true;
            this.labelSalgsPris.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalgsPris.Location = new System.Drawing.Point(33, 402);
            this.labelSalgsPris.Name = "labelSalgsPris";
            this.labelSalgsPris.Size = new System.Drawing.Size(105, 26);
            this.labelSalgsPris.TabIndex = 11;
            this.labelSalgsPris.Text = "Salgs Pris";
            // 
            // btnForslåPris
            // 
            this.btnForslåPris.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForslåPris.Location = new System.Drawing.Point(231, 438);
            this.btnForslåPris.Name = "btnForslåPris";
            this.btnForslåPris.Size = new System.Drawing.Size(152, 40);
            this.btnForslåPris.TabIndex = 17;
            this.btnForslåPris.Text = "Forslå Pris";
            this.btnForslåPris.UseVisualStyleBackColor = true;
            // 
            // btnOpretBolig
            // 
            this.btnOpretBolig.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpretBolig.Location = new System.Drawing.Point(231, 553);
            this.btnOpretBolig.Name = "btnOpretBolig";
            this.btnOpretBolig.Size = new System.Drawing.Size(152, 40);
            this.btnOpretBolig.TabIndex = 18;
            this.btnOpretBolig.Text = "Opret Bolig";
            this.btnOpretBolig.UseVisualStyleBackColor = true;
            this.btnOpretBolig.Click += new System.EventHandler(this.btnOpretBolig_Click);
            // 
            // kaspermark_dk_db_realboligDataSet2
            // 
            this.kaspermark_dk_db_realboligDataSet2.DataSetName = "kaspermark_dk_db_realboligDataSet2";
            this.kaspermark_dk_db_realboligDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet2;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // biDDataGridViewTextBoxColumn
            // 
            this.biDDataGridViewTextBoxColumn.DataPropertyName = "BiD";
            this.biDDataGridViewTextBoxColumn.HeaderText = "BiD";
            this.biDDataGridViewTextBoxColumn.Name = "biDDataGridViewTextBoxColumn";
            this.biDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kiDDataGridViewTextBoxColumn
            // 
            this.kiDDataGridViewTextBoxColumn.DataPropertyName = "KiD";
            this.kiDDataGridViewTextBoxColumn.HeaderText = "KiD";
            this.kiDDataGridViewTextBoxColumn.Name = "kiDDataGridViewTextBoxColumn";
            // 
            // postNRDataGridViewTextBoxColumn
            // 
            this.postNRDataGridViewTextBoxColumn.DataPropertyName = "PostNR";
            this.postNRDataGridViewTextBoxColumn.HeaderText = "PostNR";
            this.postNRDataGridViewTextBoxColumn.Name = "postNRDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // områdeDataGridViewTextBoxColumn
            // 
            this.områdeDataGridViewTextBoxColumn.DataPropertyName = "Område";
            this.områdeDataGridViewTextBoxColumn.HeaderText = "Område";
            this.områdeDataGridViewTextBoxColumn.Name = "områdeDataGridViewTextBoxColumn";
            // 
            // salgsPrisDataGridViewTextBoxColumn
            // 
            this.salgsPrisDataGridViewTextBoxColumn.DataPropertyName = "SalgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.HeaderText = "SalgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.Name = "salgsPrisDataGridViewTextBoxColumn";
            // 
            // salgsDatoDataGridViewTextBoxColumn
            // 
            this.salgsDatoDataGridViewTextBoxColumn.DataPropertyName = "SalgsDato";
            this.salgsDatoDataGridViewTextBoxColumn.HeaderText = "SalgsDato";
            this.salgsDatoDataGridViewTextBoxColumn.Name = "salgsDatoDataGridViewTextBoxColumn";
            // 
            // kvmDataGridViewTextBoxColumn
            // 
            this.kvmDataGridViewTextBoxColumn.DataPropertyName = "Kvm";
            this.kvmDataGridViewTextBoxColumn.HeaderText = "Kvm";
            this.kvmDataGridViewTextBoxColumn.Name = "kvmDataGridViewTextBoxColumn";
            // 
            // kaspermark_dk_db_realboligDataSet
            // 
            this.kaspermark_dk_db_realboligDataSet.DataSetName = "kaspermark_dk_db_realboligDataSet";
            this.kaspermark_dk_db_realboligDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kaspermarkdkdbrealboligDataSetBindingSource
            // 
            this.kaspermarkdkdbrealboligDataSetBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet;
            this.kaspermarkdkdbrealboligDataSetBindingSource.Position = 0;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet2;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // kiDDataGridViewTextBoxColumn1
            // 
            this.kiDDataGridViewTextBoxColumn1.DataPropertyName = "KiD";
            this.kiDDataGridViewTextBoxColumn1.HeaderText = "KiD";
            this.kiDDataGridViewTextBoxColumn1.Name = "kiDDataGridViewTextBoxColumn1";
            this.kiDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fuldeNavnDataGridViewTextBoxColumn
            // 
            this.fuldeNavnDataGridViewTextBoxColumn.DataPropertyName = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.HeaderText = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.Name = "fuldeNavnDataGridViewTextBoxColumn";
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "Tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "Tlf";
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn1
            // 
            this.adresseDataGridViewTextBoxColumn1.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.Name = "adresseDataGridViewTextBoxColumn1";
            // 
            // CreateBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 789);
            this.Controls.Add(this.btnOpretBolig);
            this.Controls.Add(this.btnForslåPris);
            this.Controls.Add(this.mSalgsPrisTextbox);
            this.Controls.Add(this.labelSalgsPris);
            this.Controls.Add(this.mKvmTextbox);
            this.Controls.Add(this.labelKvm);
            this.Controls.Add(this.mOmrådeTextbox);
            this.Controls.Add(this.labelOmråde);
            this.Controls.Add(this.mAdresseTextbox);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.mPostNRTextbox);
            this.Controls.Add(this.labelPostNR);
            this.Controls.Add(this.mKiDTextbox);
            this.Controls.Add(this.labelKiD);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateBolig";
            this.Text = "CreateBolig";
            this.Load += new System.EventHandler(this.CreateBolig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBoligTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabKundeTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermarkdkdbrealboligDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBoligTabel;
        private System.Windows.Forms.TabPage tabKundeTabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelKiD;
        private System.Windows.Forms.MaskedTextBox mKiDTextbox;
        private System.Windows.Forms.MaskedTextBox mPostNRTextbox;
        private System.Windows.Forms.Label labelPostNR;
        private System.Windows.Forms.MaskedTextBox mAdresseTextbox;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.MaskedTextBox mOmrådeTextbox;
        private System.Windows.Forms.Label labelOmråde;
        private System.Windows.Forms.MaskedTextBox mKvmTextbox;
        private System.Windows.Forms.Label labelKvm;
        private System.Windows.Forms.MaskedTextBox mSalgsPrisTextbox;
        private System.Windows.Forms.Label labelSalgsPris;
        private System.Windows.Forms.Button btnForslåPris;
        private System.Windows.Forms.Button btnOpretBolig;
        private kaspermark_dk_db_realboligDataSet2 kaspermark_dk_db_realboligDataSet2;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private kaspermark_dk_db_realboligDataSet2TableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn områdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kaspermarkdkdbrealboligDataSetBindingSource;
        private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn1;
    }
}
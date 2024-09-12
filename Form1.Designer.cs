namespace WDLoadSpecialDay
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtResponseCode = new System.Windows.Forms.TextBox();
            this.txtRowsInserted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.watchdogDataSet = new WDLoadSpecialDay.WatchdogDataSet();
            this.special_DaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.special_DaysTableAdapter = new WDLoadSpecialDay.WatchdogDataSetTableAdapters.Special_DaysTableAdapter();
            this.tableAdapterManager = new WDLoadSpecialDay.WatchdogDataSetTableAdapters.TableAdapterManager();
            this.special_DaysDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.watchdogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_DaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_DaysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(23, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(175, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResponseCode
            // 
            this.txtResponseCode.Enabled = false;
            this.txtResponseCode.Location = new System.Drawing.Point(20, 126);
            this.txtResponseCode.Name = "txtResponseCode";
            this.txtResponseCode.Size = new System.Drawing.Size(83, 20);
            this.txtResponseCode.TabIndex = 1;
            this.txtResponseCode.Text = "0";
            // 
            // txtRowsInserted
            // 
            this.txtRowsInserted.Enabled = false;
            this.txtRowsInserted.Location = new System.Drawing.Point(123, 124);
            this.txtRowsInserted.Name = "txtRowsInserted";
            this.txtRowsInserted.Size = new System.Drawing.Size(83, 20);
            this.txtRowsInserted.TabIndex = 2;
            this.txtRowsInserted.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Response Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rows Inserted";
            // 
            // watchdogDataSet
            // 
            this.watchdogDataSet.DataSetName = "WatchdogDataSet";
            this.watchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // special_DaysBindingSource
            // 
            this.special_DaysBindingSource.DataMember = "Special_Days";
            this.special_DaysBindingSource.DataSource = this.watchdogDataSet;
            // 
            // special_DaysTableAdapter
            // 
            this.special_DaysTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Special_DaysTableAdapter = this.special_DaysTableAdapter;
            this.tableAdapterManager.UpdateOrder = WDLoadSpecialDay.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // special_DaysDataGridView
            // 
            this.special_DaysDataGridView.AllowUserToAddRows = false;
            this.special_DaysDataGridView.AllowUserToDeleteRows = false;
            this.special_DaysDataGridView.AutoGenerateColumns = false;
            this.special_DaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.special_DaysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.special_DaysDataGridView.DataSource = this.special_DaysBindingSource;
            this.special_DaysDataGridView.Location = new System.Drawing.Point(178, 73);
            this.special_DaysDataGridView.Name = "special_DaysDataGridView";
            this.special_DaysDataGridView.ReadOnly = true;
            this.special_DaysDataGridView.Size = new System.Drawing.Size(20, 13);
            this.special_DaysDataGridView.TabIndex = 6;
            this.special_DaysDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Special_Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Special_Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Special_Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Special_Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Special_Greeting";
            this.dataGridViewTextBoxColumn3.HeaderText = "Special_Greeting";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Special_Comment";
            this.dataGridViewTextBoxColumn4.HeaderText = "Special_Comment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(20, 77);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(83, 20);
            this.txtYear.TabIndex = 7;
            this.txtYear.Text = "2016";
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.special_DaysDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRowsInserted);
            this.Controls.Add(this.txtResponseCode);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "WDLoadSpecialDay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.watchdogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_DaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_DaysDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtResponseCode;
        private System.Windows.Forms.TextBox txtRowsInserted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WatchdogDataSet watchdogDataSet;
        private System.Windows.Forms.BindingSource special_DaysBindingSource;
        private WatchdogDataSetTableAdapters.Special_DaysTableAdapter special_DaysTableAdapter;
        private WatchdogDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView special_DaysDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
    }
}


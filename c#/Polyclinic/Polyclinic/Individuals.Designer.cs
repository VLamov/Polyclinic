
namespace Polyclinic
{
    partial class Individuals
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
            this.panelData = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.polyclinicDataSet = new Polyclinic.PolyclinicDataSet();
            this.individualsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.individualsTableAdapter = new Polyclinic.PolyclinicDataSetTableAdapters.IndividualsTableAdapter();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurancepolicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNKPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDhouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1004, 94);
            this.panelData.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.dataGridView2);
            this.panelDataGrid.Controls.Add(this.dataGridView1);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 94);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1004, 237);
            this.panelDataGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1004, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNNDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.bplDataGridViewTextBoxColumn,
            this.insurancepolicyDataGridViewTextBoxColumn,
            this.phonesDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.jobNumberDataGridViewTextBoxColumn,
            this.iNNKPPDataGridViewTextBoxColumn,
            this.iDadressDataGridViewTextBoxColumn,
            this.iDStreetDataGridViewTextBoxColumn,
            this.iDhouseDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.individualsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1004, 237);
            this.dataGridView2.TabIndex = 1;
            // 
            // polyclinicDataSet
            // 
            this.polyclinicDataSet.DataSetName = "PolyclinicDataSet";
            this.polyclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // individualsBindingSource
            // 
            this.individualsBindingSource.DataMember = "Individuals";
            this.individualsBindingSource.DataSource = this.polyclinicDataSet;
            this.individualsBindingSource.CurrentChanged += new System.EventHandler(this.individualsBindingSource_CurrentChanged);
            // 
            // individualsTableAdapter
            // 
            this.individualsTableAdapter.ClearBeforeFill = true;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // genDataGridViewTextBoxColumn
            // 
            this.genDataGridViewTextBoxColumn.DataPropertyName = "gen";
            this.genDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // bplDataGridViewTextBoxColumn
            // 
            this.bplDataGridViewTextBoxColumn.DataPropertyName = "bpl";
            this.bplDataGridViewTextBoxColumn.HeaderText = "Место рождения";
            this.bplDataGridViewTextBoxColumn.Name = "bplDataGridViewTextBoxColumn";
            // 
            // insurancepolicyDataGridViewTextBoxColumn
            // 
            this.insurancepolicyDataGridViewTextBoxColumn.DataPropertyName = "Insurance_policy";
            this.insurancepolicyDataGridViewTextBoxColumn.HeaderText = "Страховой полис";
            this.insurancepolicyDataGridViewTextBoxColumn.Name = "insurancepolicyDataGridViewTextBoxColumn";
            // 
            // phonesDataGridViewTextBoxColumn
            // 
            this.phonesDataGridViewTextBoxColumn.DataPropertyName = "Phones";
            this.phonesDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonesDataGridViewTextBoxColumn.Name = "phonesDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // jobNumberDataGridViewTextBoxColumn
            // 
            this.jobNumberDataGridViewTextBoxColumn.DataPropertyName = "Job_Number";
            this.jobNumberDataGridViewTextBoxColumn.HeaderText = "Job_Number";
            this.jobNumberDataGridViewTextBoxColumn.Name = "jobNumberDataGridViewTextBoxColumn";
            // 
            // iNNKPPDataGridViewTextBoxColumn
            // 
            this.iNNKPPDataGridViewTextBoxColumn.DataPropertyName = "INN_KPP";
            this.iNNKPPDataGridViewTextBoxColumn.HeaderText = "INN_KPP";
            this.iNNKPPDataGridViewTextBoxColumn.Name = "iNNKPPDataGridViewTextBoxColumn";
            // 
            // iDadressDataGridViewTextBoxColumn
            // 
            this.iDadressDataGridViewTextBoxColumn.DataPropertyName = "ID_adress";
            this.iDadressDataGridViewTextBoxColumn.HeaderText = "ID_adress";
            this.iDadressDataGridViewTextBoxColumn.Name = "iDadressDataGridViewTextBoxColumn";
            // 
            // iDStreetDataGridViewTextBoxColumn
            // 
            this.iDStreetDataGridViewTextBoxColumn.DataPropertyName = "ID_Street";
            this.iDStreetDataGridViewTextBoxColumn.HeaderText = "ID_Street";
            this.iDStreetDataGridViewTextBoxColumn.Name = "iDStreetDataGridViewTextBoxColumn";
            // 
            // iDhouseDataGridViewTextBoxColumn
            // 
            this.iDhouseDataGridViewTextBoxColumn.DataPropertyName = "ID_house";
            this.iDhouseDataGridViewTextBoxColumn.HeaderText = "ID_house";
            this.iDhouseDataGridViewTextBoxColumn.Name = "iDhouseDataGridViewTextBoxColumn";
            // 
            // Individuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 331);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelData);
            this.Name = "Individuals";
            this.Text = "Физические лица";
            this.Load += new System.EventHandler(this.Individuals_Load);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PolyclinicDataSet polyclinicDataSet;
        private System.Windows.Forms.BindingSource individualsBindingSource;
        private PolyclinicDataSetTableAdapters.IndividualsTableAdapter individualsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurancepolicyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNKPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDhouseDataGridViewTextBoxColumn;
    }
}
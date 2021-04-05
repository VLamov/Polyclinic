
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Individuals));
            this.panelRecord = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonEditAddress = new System.Windows.Forms.Button();
            this.comboBoxJob_Number = new System.Windows.Forms.ComboBox();
            this.comboBoxWork = new System.Windows.Forms.ComboBox();
            this.textBoxPolice = new System.Windows.Forms.TextBox();
            this.textBoxBPL = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelJob_Number = new System.Windows.Forms.Label();
            this.labelWork = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPolic = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBpl = new System.Windows.Forms.Label();
            this.labelINN = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDOB = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.textBoxLast_Name = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelLast_Name = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelHead = new System.Windows.Forms.Label();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.panelRecord.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRecord
            // 
            this.panelRecord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRecord.Controls.Add(this.buttonDelete);
            this.panelRecord.Controls.Add(this.buttonCancel);
            this.panelRecord.Controls.Add(this.buttonUpdate);
            this.panelRecord.Controls.Add(this.buttonAdd);
            this.panelRecord.Controls.Add(this.buttonOk);
            this.panelRecord.Controls.Add(this.groupBox2);
            this.panelRecord.Controls.Add(this.groupBox1);
            this.panelRecord.Controls.Add(this.panelHead);
            this.panelRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecord.Location = new System.Drawing.Point(0, 0);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(1008, 340);
            this.panelRecord.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::Polyclinic.Properties.Resources.Корзина_32;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Location = new System.Drawing.Point(112, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(40, 40);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(888, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackgroundImage = global::Polyclinic.Properties.Resources.Ручка_32;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUpdate.Location = new System.Drawing.Point(66, 291);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::Polyclinic.Properties.Resources.плюс_32;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdd.Location = new System.Drawing.Point(20, 291);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 40);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(782, 290);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 40);
            this.buttonOk.TabIndex = 18;
            this.buttonOk.Text = "Принять";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox2.Controls.Add(this.buttonEditAddress);
            this.groupBox2.Controls.Add(this.comboBoxJob_Number);
            this.groupBox2.Controls.Add(this.comboBoxWork);
            this.groupBox2.Controls.Add(this.textBoxPolice);
            this.groupBox2.Controls.Add(this.textBoxBPL);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.textBoxAddress);
            this.groupBox2.Controls.Add(this.textBoxINN);
            this.groupBox2.Controls.Add(this.labelAddress);
            this.groupBox2.Controls.Add(this.labelJob_Number);
            this.groupBox2.Controls.Add(this.labelWork);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.labelPolic);
            this.groupBox2.Controls.Add(this.labelPhone);
            this.groupBox2.Controls.Add(this.labelBpl);
            this.groupBox2.Controls.Add(this.labelINN);
            this.groupBox2.Location = new System.Drawing.Point(394, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 208);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(98, 90);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(152, 24);
            this.maskedTextBoxPhone.TabIndex = 23;
            // 
            // buttonEditAddress
            // 
            this.buttonEditAddress.BackgroundImage = global::Polyclinic.Properties.Resources.Ручка_32;
            this.buttonEditAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditAddress.Location = new System.Drawing.Point(554, 42);
            this.buttonEditAddress.Name = "buttonEditAddress";
            this.buttonEditAddress.Size = new System.Drawing.Size(40, 40);
            this.buttonEditAddress.TabIndex = 29;
            this.buttonEditAddress.UseVisualStyleBackColor = true;
            // 
            // comboBoxJob_Number
            // 
            this.comboBoxJob_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxJob_Number.Location = new System.Drawing.Point(369, 130);
            this.comboBoxJob_Number.Name = "comboBoxJob_Number";
            this.comboBoxJob_Number.Size = new System.Drawing.Size(225, 26);
            this.comboBoxJob_Number.TabIndex = 28;
            // 
            // comboBoxWork
            // 
            this.comboBoxWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWork.Location = new System.Drawing.Point(369, 90);
            this.comboBoxWork.Name = "comboBoxWork";
            this.comboBoxWork.Size = new System.Drawing.Size(225, 26);
            this.comboBoxWork.TabIndex = 27;
            // 
            // textBoxPolice
            // 
            this.textBoxPolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPolice.Location = new System.Drawing.Point(415, 10);
            this.textBoxPolice.Name = "textBoxPolice";
            this.textBoxPolice.Size = new System.Drawing.Size(179, 24);
            this.textBoxPolice.TabIndex = 26;
            // 
            // textBoxBPL
            // 
            this.textBoxBPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBPL.Location = new System.Drawing.Point(152, 170);
            this.textBoxBPL.Name = "textBoxBPL";
            this.textBoxBPL.Size = new System.Drawing.Size(442, 24);
            this.textBoxBPL.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(97, 130);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(153, 24);
            this.textBoxEmail.TabIndex = 24;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(97, 50);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(432, 24);
            this.textBoxAddress.TabIndex = 22;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxINN.Location = new System.Drawing.Point(97, 10);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(153, 24);
            this.textBoxINN.TabIndex = 21;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(20, 53);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(50, 18);
            this.labelAddress.TabIndex = 20;
            this.labelAddress.Text = "Адрес";
            // 
            // labelJob_Number
            // 
            this.labelJob_Number.AutoSize = true;
            this.labelJob_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJob_Number.Location = new System.Drawing.Point(265, 133);
            this.labelJob_Number.Name = "labelJob_Number";
            this.labelJob_Number.Size = new System.Drawing.Size(89, 18);
            this.labelJob_Number.TabIndex = 19;
            this.labelJob_Number.Text = "Должность";
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWork.Location = new System.Drawing.Point(265, 96);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(98, 18);
            this.labelWork.TabIndex = 18;
            this.labelWork.Text = "Организация";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(20, 133);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 18);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "email";
            // 
            // labelPolic
            // 
            this.labelPolic.AutoSize = true;
            this.labelPolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPolic.Location = new System.Drawing.Point(265, 16);
            this.labelPolic.Name = "labelPolic";
            this.labelPolic.Size = new System.Drawing.Size(129, 18);
            this.labelPolic.TabIndex = 11;
            this.labelPolic.Text = "Страховой полис";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(20, 94);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 18);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Телефон";
            // 
            // labelBpl
            // 
            this.labelBpl.AutoSize = true;
            this.labelBpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBpl.Location = new System.Drawing.Point(20, 172);
            this.labelBpl.Name = "labelBpl";
            this.labelBpl.Size = new System.Drawing.Size(126, 18);
            this.labelBpl.TabIndex = 15;
            this.labelBpl.Text = "Место рождения";
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelINN.Location = new System.Drawing.Point(20, 16);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(41, 18);
            this.labelINN.TabIndex = 14;
            this.labelINN.Text = "ИНН";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxDOB);
            this.groupBox1.Controls.Add(this.comboBoxGen);
            this.groupBox1.Controls.Add(this.textBoxLast_Name);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxFamily);
            this.groupBox1.Controls.Add(this.labelDob);
            this.groupBox1.Controls.Add(this.labelGen);
            this.groupBox1.Controls.Add(this.labelLast_Name);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelFamily);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 208);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBoxDOB
            // 
            this.maskedTextBoxDOB.Location = new System.Drawing.Point(137, 169);
            this.maskedTextBoxDOB.Mask = "00/00/0000";
            this.maskedTextBoxDOB.Name = "maskedTextBoxDOB";
            this.maskedTextBoxDOB.Size = new System.Drawing.Size(233, 24);
            this.maskedTextBoxDOB.TabIndex = 16;
            this.maskedTextBoxDOB.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.comboBoxGen.Location = new System.Drawing.Point(137, 130);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(233, 26);
            this.comboBoxGen.TabIndex = 15;
            // 
            // textBoxLast_Name
            // 
            this.textBoxLast_Name.Location = new System.Drawing.Point(137, 90);
            this.textBoxLast_Name.Name = "textBoxLast_Name";
            this.textBoxLast_Name.Size = new System.Drawing.Size(233, 24);
            this.textBoxLast_Name.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 24);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.Location = new System.Drawing.Point(137, 10);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(233, 24);
            this.textBoxFamily.TabIndex = 12;
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDob.Location = new System.Drawing.Point(8, 172);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(116, 18);
            this.labelDob.TabIndex = 10;
            this.labelDob.Text = "Дата рождения";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGen.Location = new System.Drawing.Point(8, 133);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(37, 18);
            this.labelGen.TabIndex = 9;
            this.labelGen.Text = "Пол";
            // 
            // labelLast_Name
            // 
            this.labelLast_Name.AutoSize = true;
            this.labelLast_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLast_Name.Location = new System.Drawing.Point(8, 93);
            this.labelLast_Name.Name = "labelLast_Name";
            this.labelLast_Name.Size = new System.Drawing.Size(75, 18);
            this.labelLast_Name.TabIndex = 6;
            this.labelLast_Name.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(8, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 18);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Имя";
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFamily.Location = new System.Drawing.Point(6, 13);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(73, 18);
            this.labelFamily.TabIndex = 4;
            this.labelFamily.Text = "Фамилия";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelHead.Controls.Add(this.buttonSearch);
            this.panelHead.Controls.Add(this.textBoxSearch);
            this.panelHead.Controls.Add(this.labelHead);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1008, 70);
            this.panelHead.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::Polyclinic.Properties.Resources.Лупа_32;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.Location = new System.Drawing.Point(954, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(40, 40);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(546, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(400, 38);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHead.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHead.Location = new System.Drawing.Point(32, 15);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(236, 29);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Физические лица";
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDataGrid.Controls.Add(this.dataGridView1);
            this.panelDataGrid.Controls.Add(this.statusStrip1);
            this.panelDataGrid.Controls.Add(this.dataGridViewTable);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 340);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1008, 221);
            this.panelDataGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 199);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.statusRows);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "Текущая запись:";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.Size = new System.Drawing.Size(1008, 221);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // Individuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 39);
            this.Name = "Individuals";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Load += new System.EventHandler(this.Individuals_Load);
            this.panelRecord.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            this.panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelJob_Number;
        private System.Windows.Forms.Label labelWork;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBpl;
        private System.Windows.Forms.Label labelINN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPolic;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelLast_Name;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonEditAddress;
        private System.Windows.Forms.ComboBox comboBoxJob_Number;
        private System.Windows.Forms.ComboBox comboBoxWork;
        private System.Windows.Forms.TextBox textBoxPolice;
        private System.Windows.Forms.TextBox textBoxBPL;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.TextBox textBoxLast_Name;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDOB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
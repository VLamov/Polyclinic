using System;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;
using Npgsql;


namespace Polyclinic
{
    public partial class Individuals : Form
    {
        private string id = "";
        private int intRow = 0;
        private int intRows = 0;
        public int cur_Address = 0;
        public int cur_Street = 0;
        public int cur_House = 0;
        private int cur_search = 0;
        private string k = DB.k();
        private DataTable t_work;
        private DataTable t_jobs;


        public Individuals()
        {
            InitializeComponent();
            ResetTextFields();
            getCatalogs();
        }

        private void ResetTextFields()
        {
            cur_search = 0;
            textBoxSearch.Clear();
            comboBoxJob_Number.Text = "";
            comboBoxWork.Text = "";
            textBoxPolice.Text = "";
            textBoxBPL.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            textBoxINN.Text = "";
            textBoxLast_Name.Text = "";
            textBoxName.Text = "";
            textBoxFamily.Text = "";
            maskedTextBoxPhone.Text = "";
            maskedTextBoxDOB.Text = "";
            comboBoxGen.SelectedIndex = 0;

            if (textBoxSearch.CanSelect)
                textBoxSearch.Select();


        }

        private void Individuals_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void LoadData(string KeyWord)
        {
            string t_ind = k + "Individuals" + k;
            string t_adr = k + "Adresses" + k;
            string t_job = k + "Job_Classifier" + k;
            string t_work = k + "Work_places" + k;
            string sql;

            sql = "select " + k + "INN" + k + " as ИНН, " +
                k + "Family" + k + " as Фамилия, " +
                k + "Name" + k + " as Имя, " +
                k + "Last_Name" + k + " as Отчество," +
                "gen as Пол, " +
                "to_char(" + k + "DOB" + k + ", 'dd.mm.yyyy') as " + k + "Дата рождения" + k +
                ", bpl as " + k + "Место рождения" + k + ", " +
                k + "Insurance_policy" + k + " as " + k + "Страховой полис" + k + ", " +
                k + "Phones" + k + " as Телефон, email, " +
                k + "Sity" + k + " as Город, " +
                k + "Street_Name" + k + " as Улица, " +
                k + "House_number" + k + " as Дом, " +
                k + "Housing_house" + k + " as Корпус, " +
                k + "porch" + k + " as Подъезд, " +
                k + "Apartment_number" + k + " as Квартира, " +
                k + "Job_title" + k + " as Должность, " +
                k + "Work_name" + k + " as Организация" +
            " from " + t_ind +
            " left join " + t_adr +
            " on " + t_adr + "." + k + "ID_adress" + k + " = " + t_ind + "." + k + "ID_adress" + k +
            " left join " + k + "Streets" + k +
            " on " + k + "Streets" + k + "." + k + "ID_Street" + k + " = " + t_adr + "." + k + "ID_Street" + k +
            " left join " + k + "Houses" + k +
            " on " + t_adr + "." + k + "ID_house" + k + " = " + k + "Houses" + k + "." + k + "ID_house" + k +
            " left join " + t_job +
            " on " + t_job + "." + k + "Job_Number" + k + " = " + t_ind + "." + k + "Job_Number" + k +
            " left join  " + t_work +
            " on " + t_work + "." + k + "INN_KPP" + k + " = " + t_ind + "." + k + "INN_KPP" + k;

            DataTable dt = DB.SQLGetTable(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            statusRows();
        }

        private void Execute(string sql, string parameters)
        {
            DB db = new DB();
            DB.command = new NpgsqlCommand(sql, db.getConnection());
            addparameters(parameters);
        }

        private void addparameters(string parameters)
        {
            DB.command.Parameters.Clear();
            DB.command.Parameters.AddWithValue("Family", textBoxFamily.Text.Trim());
            DB.command.Parameters.AddWithValue("Name", textBoxName.Text.Trim());
            DB.command.Parameters.AddWithValue("Last_Name", textBoxLast_Name.Text.Trim());
            DB.command.Parameters.AddWithValue("INN", textBoxINN.Text.Trim());
            DB.command.Parameters.AddWithValue("gen", comboBoxGen.SelectedItem.ToString());
            DB.command.Parameters.AddWithValue("DOB", DB.toData(maskedTextBoxDOB.Text.ToString()));
            DB.command.Parameters.AddWithValue("bpl", textBoxBPL.Text.Trim());
            DB.command.Parameters.AddWithValue("Insurance_policy", textBoxPolice.Text.Trim());
            DB.command.Parameters.AddWithValue("Phones", maskedTextBoxPhone.Text.Trim());
            DB.command.Parameters.AddWithValue("email", textBoxEmail.Text.Trim());
            DB.command.Parameters.AddWithValue("INN_KPP", comboBoxWork.Text.Trim());
            DB.command.Parameters.AddWithValue("Job_Number", comboBoxJob_Number.Text.Trim());
            //DB.command.Parameters.AddWithValue("ID_adress", textBoxAddress.Text.Trim());
            //DB.command.Parameters.AddWithValue("ID_Street", textBoxAddress.Text.Trim());
            //DB.command.Parameters.AddWithValue("ID_house", textBoxAddress.Text.Trim());

            if (parameters == "Update" || parameters == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                DB.command.Parameters.AddWithValue("id", this.id);
            }
        }

        private void statusRows()
        {
            intRows = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            intRow = Convert.ToInt32(dataGridView1.CurrentCellAddress.Y.ToString());
            toolStripStatusLabel1.Text = "Текущая запись: " + intRow.ToString() + " из " + intRows.ToString();
        }
        
        private void getCatalogs()
        {
            string t_ind = k + "Work_places" + k;
            string sql = "Select DISTINCT * from " + t_ind;
            t_work = DB.SQLGetTable(sql);
            comboBoxWork.DataSource = t_work;
            comboBoxWork.DisplayMember = "Work_name";
            comboBoxWork.ValueMember = "INN_KPP";
            t_ind = k + "Job_Classifier" + k;
            sql = "Select DISTINCT * from " + t_ind;
            t_jobs = DB.SQLGetTable(sql);
            comboBoxJob_Number.DataSource = t_jobs;
            comboBoxJob_Number.DisplayMember = "Job_title";
            comboBoxJob_Number.ValueMember = "Job_Number";
        }

        private Boolean CorrectField()
        {
            Boolean AllNice = false;
            if (string.IsNullOrEmpty(textBoxINN.Text.Trim()))
            {
                textBoxINN.Select();
                string head = "Внимание! ИНН пустой";
                string str = "Введите, пожалуйста ИНН";
                MessageBox.Show(str, head,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return AllNice;
            }
            if (string.IsNullOrEmpty(textBoxFamily.Text.Trim()))
            {
                textBoxFamily.Select();
                string head = "Внимание! Фамилии нет";
                string str = "Введите, пожалуйста фамилию";
                MessageBox.Show(str, head,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return AllNice;
            }
            if (string.IsNullOrEmpty(textBoxName.Text.Trim()))
            {
                textBoxName.Select();
                string head = "Внимание! Имени нет";
                string str = "Введите, пожалуйста имя";
                MessageBox.Show(str, head,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return AllNice;
            }
            if (string.IsNullOrEmpty(textBoxLast_Name.Text.Trim()))
            {
                textBoxLast_Name.Select();
                string head = "Внимание! Отчества нет";
                string str = "Введите, пожалуйста отчество";
                MessageBox.Show(str, head,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return AllNice;
            }
            if (string.IsNullOrEmpty(maskedTextBoxDOB.Text.Trim()))
            {
                maskedTextBoxDOB.Select();
                string head = "Внимание! Даты рождения нет";
                string str = "Введите, пожалуйста дату рождения";
                MessageBox.Show(str, head,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return AllNice;
            }
            if (string.IsNullOrEmpty(comboBoxGen.SelectedItem.ToString()))
            {
                comboBoxGen.Select();
                string head = "Внимание! Пол не указан";
                string str = "Выберите, пожалуйста пол";
                MessageBox.Show(str, head,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return AllNice;
            }
            if (string.IsNullOrEmpty(textBoxPolice.Text.Trim()))
            {
                textBoxPolice.Select();
                string head = "Внимание! Страховой полис не указан";
                string str = "Введите, пожалуйста номер страхового полиса";
                MessageBox.Show(str, head,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return AllNice;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CorrectField())
            {
                LoadData("");
            }
            else return;

            /*           DB.sql = "INSERT INTO Individuals(" +
                               "INN, " +
                               "Family, " +
                               "Name, " +
                               "Last_Name, " +
                               "gen, " +
                               "DOB, " +
                               "bpl, " +
                               "Insurance_policy, " +
                               "Phones, email, " +
                               "Job_Number, " +
                               "INN_KPP, " +
                               "ID_adress, " +
                               "ID_Street, " +
                               "ID_house) " +
                           "VALUES " +
                               "@INN, " +
                               "@Family, " +
                               "@Name, " +
                               "@Last_Name, " +
                               "@gen, " +
                               "@DOB, " +
                               "@bpl, " +
                               "@Insurance_policy, " +
                               "@Phones, " +
                               "@email, " +
                               "@Job_Number, " +
                               "@INN_KPP, " +
                               "@ID_adress, " +
                               "@ID_Street, " +
                               "@ID_house";

                       Execute(DB.sql, "Insert");
            */

            string head = "Запись успешно добавлена";
            string str = "В базу добавлена строка " +
                textBoxFamily.Text.Trim() + " " +
                textBoxLast_Name.Text.Trim() + " " +
                textBoxLast_Name.Text.Trim();
            MessageBox.Show(str, head,
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetTextFields();
        }

        private string cellsValue(int col)
        {
            return Convert.ToString(dataGridView1.CurrentRow.Cells[col].Value).Trim();
        }

        private void FillTextField()
        {
            textBoxINN.Text = cellsValue(0);
            textBoxFamily.Text = cellsValue(1);
            textBoxName.Text = cellsValue(2);
            textBoxLast_Name.Text = cellsValue(3);
            comboBoxGen.SelectedItem = cellsValue(4);
            maskedTextBoxDOB.Text = cellsValue(5);
            textBoxBPL.Text = cellsValue(6);
            textBoxPolice.Text = cellsValue(7);
            maskedTextBoxPhone.Text = cellsValue(8).PadLeft(11, ' ');
            textBoxEmail.Text = cellsValue(9);
            textBoxAddress.Text = cellsValue(10);
            textBoxAddress.Text += ", " + cellsValue(11);
            textBoxAddress.Text += ", " + cellsValue(12);
            if (cellsValue(13).Length > 0)
                textBoxAddress.Text += "-" + cellsValue(13);
            if (cellsValue(15).Length > 0)
                textBoxAddress.Text += "-" + cellsValue(15);
            /*//comboBoxWork.Text = cellsValue(17);
            int line = comboBoxWork.FindString(cellsValue(17));
            {
                line.Contains(cellsValue(17));
            }

            ///comboBoxJob_Number.Text = cellsValue(16); 
            foreach (ComboBoxItem cbi in comboBoxWork.Items)
            {
                if (cbi.Content as String == cellsValue(17))
                {
                    comboBoxWork.SelectedItem = cbi;
                    break;
                }
            }
            comboBoxWork.SelectedIndex = comboBoxWork.SelectedText. .FindStringExact(cellsValue(17));
            comboBoxJob_Number.SelectedIndex = comboBoxWork.FindStringExact(cellsValue(16));*/
            comboBoxWork.Text = cellsValue(17);
            comboBoxJob_Number.Text = cellsValue(16);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusRows();
            if (e.RowIndex != -1)
            {
                FillTextField();
            }
        }

        private void statusRows(object sender, EventArgs e)
        {
            statusRows();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            FillTextField();
            if (!CorrectField()) return;
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim().Length == 0) return;
            if (cur_search < dataGridView1.RowCount - 1)
                cur_search++;
            else
                cur_search = 0;

            for (; cur_search < dataGridView1.RowCount; cur_search++)
                if (dataGridView1[1, cur_search].FormattedValue.ToString().ToUpper().
                    Contains(textBoxSearch.Text.Trim().ToUpper()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, cur_search];
                    FillTextField();
                    return;
                }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string head = "Комбобокс";
            string str = "Содерхимое комбобоксов : \n" +
                comboBoxWork.SelectedValue.ToString().Trim() + "\n " +
                comboBoxWork.Items.ToString().Trim() + "\n " +
                comboBoxJob_Number.SelectedValue.ToString().Trim() + "\n " +
                comboBoxJob_Number.Items.ToString().Trim();
            MessageBox.Show(str, head,
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

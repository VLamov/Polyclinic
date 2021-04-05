using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Polyclinic
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string UserLogin = Login.Text;
            string UserPass = pass.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            ///string sql = "select * from check_password(@uL, @uP)";
            string sql = "select * from check_login(@uL, @uP)";
            NpgsqlCommand command = new NpgsqlCommand(sql, db.getConnection());
            command.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Text).Value = UserLogin;
            command.Parameters.Add("@uP", NpgsqlTypes.NpgsqlDbType.Text).Value = UserPass;

            ///adapter.SelectCommand = command;
            ///adapter.Fill(table);
            db.openConnection();

            int result = (int)command.ExecuteScalar();
            db.closeConnection();

            ///if (table.Rows.Count > 0)
            if (result == 0)
            {
                MessageBox.Show("Спасибо. Авторизация прошла успешно.");
                ///MdiParent.UserLogin = UserLogin;
                ///Desktop.ActiveForm.Userlogin = UserLogin;
                Desktop D = (Desktop)this.Owner;
                D.Userlogin = UserLogin;
                this.Close();
               /// new Desktop(UserLogin).Show();
            }
            else
            {
                MessageBox.Show("Простите. Авторизация завершилась неудачей.");
                Application.Exit();
            }
        }

        Point LastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}

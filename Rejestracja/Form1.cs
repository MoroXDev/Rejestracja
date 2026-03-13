using System.Text.RegularExpressions;

namespace Rejestracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (username_box.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa użytkownika jest pusta.");
                return;
            }

            foreach (ListViewItem account in listView1.Items)
            {
                if (account.SubItems[0].Text == username_box.Text.Trim())
                {
                    MessageBox.Show("Nazwa użytkownika jest już zajęta.");
                    return;
                }
            }

            if (!Regex.IsMatch(email_box.Text.Trim(), pattern))
            {
                MessageBox.Show("Email jest nieprawidłowy.");
                return;
            }

            if (password_box.Text.Trim() == "")
            {
                MessageBox.Show("Hasło jest puste.");
                return;
            }
            if (password_box.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Hasło nie powinno zawierać spacji.");
                return;
            }

            if (!terms_check.Checked)
            {
                MessageBox.Show("Nie zaakceptowano regulaminu.");
                return;
            }

            listView1.Items.Add(new ListViewItem(new string[] { username_box.Text.Trim(), email_box.Text.Trim(), password_box.Text.Trim() }));
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }
    }
}

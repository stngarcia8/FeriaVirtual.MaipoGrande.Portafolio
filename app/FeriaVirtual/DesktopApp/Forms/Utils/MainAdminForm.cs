using FeriaVirtual.App.Desktop.SeedWork.FormsControls;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Utils
{
    public partial class MainAdminForm : MaterialForm
    {

        //private readonly ThemeManager _themeManager;

        public MainAdminForm()
        {
            InitializeComponent();
            //_themeManager = ThemeManager.SubscribeForm(this);
        }


        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            this.UserToolStripStatusLabel.Text = SessionData.FullName;
            this.ProfileToolStripStatusLabel.Text = SessionData.Profile.SingleProfileName;
        }


        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MaterialMessageBox.Show("¿Esta seguro(a) de salir de la aplicación?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes)) {
                e.Cancel = false;
                //_themeManager.UnsubscribeForm(this);
                return;
            }
            e.Cancel = true;
        }


        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialForm form = new PreferencesForm();
            form.ShowDialog();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}

using FeriaVirtual.App.Desktop.SeedWork.FormsControls;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Utils
{
    public partial class PreferencesForm : MaterialForm
    {
        private readonly ThemeManager _themeManager;
        private int _rowsPerPage;
        private int _darkMode;
        private int _colorSchema;

        public PreferencesForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SubscribeForm(this);
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            BackupOriginalValues();
            PutValuesIntoControls();
            PaginationNumericUpDown.Focus();
        }


        private void AceptFormButton_Click(object sender, EventArgs e)
        {
            ExtractValuesFromControls();
            AsignFormStatusValues();
            _themeManager.UnsubscribeForm(this);
            Close();
        }


        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            _themeManager.UnsubscribeForm(this);
            Close();
        }


        private void ApplyFormButton_Click(object sender, EventArgs e)
        {
            ExtractValuesFromControls();
            AsignFormStatusValues();
        }

        private void AsignFormStatusValues()
        {
            _themeManager.ChangeTheme(VisualizationDarkModeSwitch.CheckState.Equals(CheckState.Checked) ? 1 : 0);
            _themeManager.ChangeColorSchema(VisualizationSchemaComboBox.SelectedIndex);
        }

        private void BackupOriginalValues()
        {
            _rowsPerPage = PreferenceData.RowsPerPage;
            _darkMode = PreferenceData.DarkMode;
            _colorSchema = PreferenceData.ColorSchema;
        }


        private void PutValuesIntoControls()
        {
            PaginationNumericUpDown.Value = _rowsPerPage;
            VisualizationDarkModeSwitch.CheckState = _darkMode.Equals(1) ? CheckState.Checked : CheckState.Unchecked;
            VisualizationSchemaComboBox.SelectedIndex = _colorSchema;
        }


        private void ExtractValuesFromControls()
        {
            PreferenceData.RowsPerPage = int.Parse(PaginationNumericUpDown.Value.ToString());
            PreferenceData.DarkMode = VisualizationDarkModeSwitch.CheckState.Equals(CheckState.Checked) ? 1 : 0;
            PreferenceData.ColorSchema = VisualizationSchemaComboBox.SelectedIndex;
        }




    }
}

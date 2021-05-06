using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.Themes;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Preferences;
using System;

namespace FeriaVirtual.App.Desktop.Forms.Utils
{
    public partial class PreferencesForm : MetroFramework.Forms.MetroForm
    {
        private readonly ThemeManager _themeManager;

        public bool IsSabed { get; protected set; }


        public PreferencesForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.Initialize(PreferenceData.ColorSchema, PreferenceData.DarkMode);
        }


        private void PreferencesForm_Load
            (object sender, EventArgs e)
        {
            IsSabed = false;
            ConfigureForm();
            RowsPerPageTextBox.Focus();
        }


        private void ConfigureForm()
        {
            RowsPerPageTextBox.Text = PreferenceData.RowsPerPage.ToString();
            ConfigureStyles();
            ThemeStyleComboBox.Text = PreferenceData.ColorSchemaName;
            ThemeLightRadioButton.Checked = PreferenceData.DarkMode.Equals(0);
            ThemeDarkRadioButton.Checked = PreferenceData.DarkMode.Equals(1);
        }


        private void ConfigureStyles()
        {
            ThemeStyleComboBox.SelectedIndexChanged -= this.ThemeStyleComboBox_SelectedIndexChanged;
            var styles = _themeManager.AvailableColors;
            var configurator = ComboboxConfigurator.Configure(ThemeStyleComboBox);
            configurator.DefineDatasource(styles, "ColorName", "Style");
            ThemeStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeStyleComboBox_SelectedIndexChanged);
        }


        private void FormSaveButton_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            Close();
        }

        private void FormCancelButton_Click
            (object sender, EventArgs e)
        {
            IsSabed = false;
            Close();
        }



        private void FormApplyButton_Click
            (object sender, EventArgs e)
            => ApplyChanges();


        private void ThemeStyleComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
            => _themeManager.ChangeColorStyle((MetroFramework.MetroColorStyle)ThemeStyleComboBox.SelectedValue);


        private void ThemeLightRadioButton_Click
            (object sender, EventArgs e)
            => _themeManager.LightMode();


        private void ThemeDarkRadioButton_Click
            (object sender, EventArgs e)
            => _themeManager.DarkMode();


        private void ApplyChanges()
        {
            PreferenceData.RowsPerPage = int.Parse(RowsPerPageTextBox.Text);
            PreferenceData.DarkMode = _themeManager.IsDarkMode ? 1 : 0;
            PreferenceData.ColorSchema = (int)ThemeStyleComboBox.SelectedValue;
            PreferenceData.ColorSchemaName = ThemeStyleComboBox.Text;
            var preferences = Preference.Build();
            preferences.WriteSettings();
            IsSabed = true;
        }



    }
}

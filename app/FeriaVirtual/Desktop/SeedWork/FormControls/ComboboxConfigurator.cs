using System.Collections.Generic;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls
{
    public class ComboboxConfigurator
    {
        private readonly ComboBox _combobox;


        private ComboboxConfigurator(ComboBox combobox) =>
            _combobox = combobox;


        public static ComboboxConfigurator Configure(ComboBox combobox) =>
            new ComboboxConfigurator(combobox);


        public void ClearCombobox() =>
            _combobox.Items.Clear();


        public void AddStringList(IList<string> items)
        {
            ClearCombobox();
            _combobox.BeginUpdate();
            foreach (string item in items)
                _combobox.Items.Add(item);
            _combobox.SelectedIndex = 0;
            _combobox.EndUpdate();
        }


        public void AddNumbers
            (int startValue, int endValue)
        {
            _combobox.BeginUpdate();
            ClearCombobox();
            for (int value = startValue; value <= endValue; value++)
                _combobox.Items.Add(value.ToString());
            _combobox.SelectedIndex = 0;
            _combobox.EndUpdate();
        }


    }
}

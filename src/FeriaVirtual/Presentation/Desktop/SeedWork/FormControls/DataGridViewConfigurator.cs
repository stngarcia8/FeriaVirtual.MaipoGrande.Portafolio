using System.Collections.Generic;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls
{
    public class DataGridViewConfigurator
    {
        private readonly MetroFramework.Controls.MetroGrid _grid;


        private DataGridViewConfigurator(MetroFramework.Controls.MetroGrid grid)
        {
            _grid = grid;
            _grid.DataSource = null;
        }

        public static DataGridViewConfigurator Configure(MetroFramework.Controls.MetroGrid grid) =>
            new DataGridViewConfigurator(grid);


        public void HideColumns(IList<string> columns)
        {
            if(_grid is null)
                return;
            foreach(var column in columns)
                _grid.Columns[column].Visible = false;
        }


        public void HideColumn(string column)
        {
            if(_grid is null)
                return;
            _grid.Columns[column].Visible = false;
        }


        public void NumericColumn(string columnName)
        {
            if(_grid is null)
                return;

            var column = _grid.Columns[columnName];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            column.DefaultCellStyle.Format = "N2";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }


        public void NumericIntegerColumn(string columnName)
        {
            if(_grid is null)
                return;

            var column = _grid.Columns[columnName];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            column.DefaultCellStyle.Format = "N0";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }


        public void CurrencyColumn(string columnName)
        {
            if(_grid is null)
                return;

            var column = _grid.Columns[columnName];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            column.DefaultCellStyle.Format = "C0";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }


        public void ChangeColumnName
            (string actualColumnName, string newColumnName)
        {
            if(_grid is null)
                return;

            var column = _grid.Columns[actualColumnName];
            column.HeaderText = newColumnName;
        }


        public void AdjustHeight()
        {
            int colHeaderHeight = _grid.ColumnHeadersHeight;
            int rowHeaderHeight = 0;
            foreach(DataGridViewRow row in _grid.Rows) {
                rowHeaderHeight += row.Height;
            }
            _grid.Height = (colHeaderHeight + rowHeaderHeight) + 25;
        }





    }
}

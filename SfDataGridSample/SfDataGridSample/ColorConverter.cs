using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class ColorConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
        {
            var dataGridRow = value as DataGridRow;
            var rowData = dataGridRow.DataRow.RowData;
            if ((rowData as Employee).EmployeeID == 1005)
                return Colors.LightBlue;
            else
                return Colors.White;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

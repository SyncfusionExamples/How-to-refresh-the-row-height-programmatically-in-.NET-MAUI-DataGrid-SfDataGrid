using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System.Reflection;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void sfGrid_QueryRowHeight(object sender, Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
                e.Handled = true;
                (sender as SfDataGrid).InvalidateRowHeight(e.RowIndex, true);
            }
        }
    }
}

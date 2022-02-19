using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.ComponentModel;
using System.Data.SqlClient;
namespace demo
{
    class OrderInfoCollection
    {

        private ObservableCollection<OrderInfo> _customer;
        public ObservableCollection<OrderInfo> Customers
        {
            get { return _customer; }
            set { _customer = value; }
        }
        public OrderInfoCollection()
        {
            _customer = new ObservableCollection<OrderInfo>();
            this.GenerateCustomer();
        }
        private void GenerateCustomer()
        {

            var dt = DateTime.Now;
            _customer.Add(new OrderInfo(10, "ABC", "1 Thành Công", "005", 0909, 10));/*, new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day),*/
            //    "Phần mềm kế toán", "15", "Nguyễn Văn A", new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day - 20)));
            //_customer.Add(new OrderInfo(11, "ABC", "2 Thành Công", "005", 0909, 10, new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day),
            //    "Phần mềm kế toán", "15", "Nguyễn Văn A", new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day - 20)));
            //_customer.Add(new OrderInfo(12, "ABC", "3 Thành Công", "005", 0909, 10, new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day),
            //    "Phần mềm kế toán", "15", "Nguyễn Văn A", new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day - 20)));
            //_customer.Add(new OrderInfo(13, "ABC", "4 Thành Công", "005", 0909, 10, new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day),
            //    "Phần mềm kế toán", "15", "Nguyễn Văn A", new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day - 20)));
            //_customer.Add(new OrderInfo(14, "ABC", "5 Thành Công", "005", 0909, 10, new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day),
            //    "Phần mềm kế toán", "15", "Nguyễn Văn A", new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day - 20)));
            //_customer.Add(new OrderInfo(15, "ABC", "6 Thành Công", "005", 0909, 10, new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day),
            //    "Phần mềm kế toán", "15", "Nguyễn Văn A", new DateTime(dt.Year, dt.Month, dt.Day - 20), new DateTime(dt.Year, dt.Month, dt.Day - 20)));
        }
    }
}

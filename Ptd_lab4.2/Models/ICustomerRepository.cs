using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptd_lab4._2.Models
{
    public interface ICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<PtdCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        PtdCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(PtdCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(PtdCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<PtdCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(PtdCustomer cus);
    }
}
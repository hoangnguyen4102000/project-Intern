using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class OrderInfo
    {
        int customerId;
        string companyName;
        string address;
        string taxCode;
        int contactNumber;
        int toTalClients;
        DateTime validFrom;
        DateTime validTo;
        string productName;
        string productVersion;
        string createBy;
        DateTime createDate;
        DateTime registerDate;

        public OrderInfo()
        { }
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string TaxCode
        {
            get { return taxCode; }
            set { taxCode = value; }
        }
        public int ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public int ToTalClients
        {
            get { return toTalClients; }
            set { toTalClients = value; }
        }
        public DateTime ValidFrom
        {
            get { return validFrom; }
            set { validFrom = value; }
        }
        public DateTime ValidTo
        {
            get { return validTo; }
            set { validTo = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductVersion
        {
            get { return productVersion; }
            set { productVersion = value; }
        }
        public string CreateBy
        {
            get { return createBy; }
            set { createBy = value; }
        }
        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        public DateTime RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }
        public OrderInfo(int CustomerId, string CompanyName, string Address, string TaxCode, int ContactNumber, int ToTalClients)/*, DateTime ValidFrom, DateTime ValidTo,*/
        //string ProductName, string ProductVersion, string CreateBy, DateTime CreateDate, DateTime RegisterDate)
        {
            this.customerId = CustomerId;
            this.companyName = CompanyName;
            this.address = Address;
            this.taxCode = TaxCode;
            this.ContactNumber = ContactNumber;
            this.toTalClients = ToTalClients;
            //this.validFrom = ValidFrom;
            //this.validTo = ValidTo;
            //this.productName = ProductName;
            //this.productVersion = ProductVersion;
            //this.createBy = CreateBy;
            //this.createDate = CreateDate;
            //this.registerDate = RegisterDate;
        }
      
    }
}

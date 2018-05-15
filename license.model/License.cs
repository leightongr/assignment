using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license.model
{
    public class License
    {

        public License()
        {

        }

        public License(String TRN)
        {
            this.Trn = TRN;
        }

        public System.Guid Id { get; set; } // Id (Primary key)
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Trn { get; set; }
        public String Type { get; set; }
        public Boolean? PPV { get; set; }
        public int? Laden { get; set; }
        public int? Unladen { get; set; }
        public int? CCRating { get; set; }
        public String PhoneNumber { get; set; }
        public String Depot { get; set; }
        public DateTime? DateCollected { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? ExpireDate { get; set; }

        public String FullName
        { get
            {
                return FirstName + " " + LastName;
            }
        }

        public override string ToString()
        {
            return Trn + " " +FirstName + " " + LastName;
        }

        public String GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public String FormatLicense()
        {
            return $"{Laden}/{Unladen}KG {Type} CC Rating: {CCRating}";
        }

        public double DateLeftBeforeExpiry()
        {
            return DateTime.Now.Subtract(ExpireDate.Value).TotalDays;
        }

        public void UpgradeLicense()
        {
            if(this.Type == "Private")
            {
                this.Type = "General";
            }
        }

        public void Renew()
        {
            ExpireDate.Value.AddYears(5);
        }

        public static String[] GetTypes()
        {
            return  new  String[]{ "Private", "General"};
        }

    }
}

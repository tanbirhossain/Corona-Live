using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Model
{
    public class CoronaVM
    {
        public string Country { get; set; }
        public int Total_Cases { get; set; }
        public int New_Cases { get; set; }
        public int Total_Deaths { get; set; }
        public int New_Deaths { get; set; }
        public int Total_Recovered { get; set; }
        public int Active_Cases { get; set; }
        public int Serious_Critical { get; set; }
        public double Tot_Cases { get; set; }
    }
    public class TotalCoronaVM
    {

        public int Total_Cases { get; set; }
        public int Total_New_Cases { get; set; }
        public int Total_Deaths { get; set; }
        public int Total_New_Deaths { get; set; }
        public int Total_Recovered { get; set; }
        public int Total_Active_Cases { get; set; }
        public int Total_Serious_Critical { get; set; }
        public double Tot_Cases { get; set; }

        
    }

    public class CoronaReturnVM
    {
        public TotalCoronaVM Total { get; set; }
        public List<CoronaVM> List { get; set; }
   
        public CoronaReturnVM()
        {
            List = new List<CoronaVM>();
            Total = new TotalCoronaVM();
        }
    }
}

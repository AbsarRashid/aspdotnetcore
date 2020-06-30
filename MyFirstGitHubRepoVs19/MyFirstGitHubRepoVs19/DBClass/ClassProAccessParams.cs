using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubRepoVs19
{
    [Serializable]
    public class ClassProAccessParams
    {

        public string Comp1 { get; set; }
        public string StoredProcedure { get; set; }
        public string Calltype { get; set; }
        public DataSet Dxml01 { get; set; }
        public DataSet Dxml02 { get; set; }
        public Byte[] Dbin01 { get; set; }
        public string Desc01 { get; set; }
        public string Desc02 { get; set; }
        public string Desc03 { get; set; }
        public string Desc04 { get; set; }
        public string Desc05 { get; set; }
        public string Desc06 { get; set; }
        public string Desc07 { get; set; }
        public string Desc08 { get; set; }
        public string Desc09 { get; set; }
        public string Desc10 { get; set; }
        public string Desc11 { get; set; }
        public string Desc12 { get; set; }
        public string Desc13 { get; set; }
        public string Desc14 { get; set; }
        public string Desc15 { get; set; }
        public string Desc16 { get; set; }
        public string Desc17 { get; set; }
        public string Desc18 { get; set; }
        public string Desc19 { get; set; }
        public string Desc20 { get; set; }
        public string Desc21 { get; set; }
        public string Desc22 { get; set; }
        public string UserID { get; set; }

        public ClassProAccessParams()
        {

        }
        public ClassProAccessParams(string _Comp1 = "", string _StoredProcedure="", string _CallType = "", DataSet _Dxml01 = null, DataSet _Dxml02 = null, Byte[] _Dbin01 = null, string _Desc01 = "", string _Desc02 = "",
            string _Desc03 = "", string _Desc04 = "", string _Desc05 = "", string _Desc06 = "", string _Desc07 = "", string _Desc08 = "", string _Desc09 = "", string _Desc10 = "", string _Desc11 = "",
                string _Desc12 = "", string _Desc13 = "", string _Desc14 = "", string _Desc15 = "", string _Desc16 = "", string _Desc17 = "", string _Desc18 = "", string _Desc19 = "", string _Desc20 = "",
                    string _Desc21 = "", string _Desc22 = "", string _UserID = "")
        {
            this.Comp1 = _Comp1;
            this.StoredProcedure = _StoredProcedure;
            this.Calltype = _CallType;
            this.Dxml01 = _Dxml01;
            this.Dxml02 = _Dxml02;
            this.Dbin01 = _Dbin01;
            this.Desc01 = _Desc01;
            this.Desc02 = _Desc02;
            this.Desc03 = _Desc03;
            this.Desc04 = _Desc04;
            this.Desc05 = _Desc05;
            this.Desc06 = _Desc06;
            this.Desc07 = _Desc07;
            this.Desc08 = _Desc08;
            this.Desc09 = _Desc09;
            this.Desc10 = _Desc10;
            this.Desc11 = _Desc11;
            this.Desc12 = _Desc12;
            this.Desc13 = _Desc13;
            this.Desc14 = _Desc14;
            this.Desc15 = _Desc15;
            this.Desc16 = _Desc16;
            this.Desc17 = _Desc17;
            this.Desc18 = _Desc18;
            this.Desc19 = _Desc19;
            this.Desc20 = _Desc20;
            this.Desc21 = _Desc21;
            this.Desc22 = _Desc22;
            this.UserID = _UserID;
        }

    }
}

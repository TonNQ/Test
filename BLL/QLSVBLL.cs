using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2110_3layers.DAL;
using _2110_3layers.DTO;

namespace _2110_3layers.BLL
{
    class QLSVBLL
    {
        public List<CBBItem> GetCBB()
        {
            List<CBBItem> cbbItems = new List<CBBItem>();
            cbbItems.Add(new CBBItem { Value = 0, Text = "All" });
            QLSV_DAL dal = new QLSV_DAL();
            foreach (LSH i in dal.GetAllLSH())
            {
                cbbItems.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                });
            }
            return cbbItems;
        }
        public List<SV> GetSVByIDLop(int ID_Lop)
        {
            List<SV> SVs = new List<SV>();
            QLSV_DAL dal = new QLSV_DAL();
            if (ID_Lop == 0)
            {
                SVs = dal.GetAllSV();
            }
            else
            {
                foreach (SV i in dal.GetAllSV())
                {
                    if (i.ID_Lop == ID_Lop)
                    {
                        SVs.Add(i); 
                    }
                }
            }
            return SVs;
        }
        public void AddSVBLL(SV s)
        {
            QLSV_DAL dal = new QLSV_DAL();
            dal.AddSVDAL(s);
        }
        public SV GetSVByMSSV(string m)
        {
            SV s = new SV();
            QLSV_DAL dal = new QLSV_DAL();
            foreach (SV i in dal.GetAllSV())
            {
                if (i.MSSV == m)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }
        public void UpdateSVBLL(SV s)
        {
            QLSV_DAL dal = new QLSV_DAL();
            dal.UpdateSVDAL(s);
        }
        public void DelSVBLL(string m)
        {
            QLSV_DAL dal = new QLSV_DAL();
            dal.DelSVDAL(m);
        }
        public List<SV> GetListSVDGV(List<string> l)
        {
            List<SV> s = new List<SV>();
            QLSV_DAL dal = new QLSV_DAL();
            foreach (string i in l)
            {
                foreach (SV j in dal.GetAllSV())
                {
                    if (j.MSSV == i)
                    {
                        s.Add(j);
                    }
                }
            }
            return s;
        }
        public List<SV> SortBy(List<string> l, string txt) 
        {
            // GetListSVDGV(l) --> list SV can sap xep
            // tien hanh sap xep --> tra ve list<SV> da duoc sap xep
            return null;
        }
    }
}

using _2110_3layers.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2110_3layers.DAL
{
    class QLSV_DAL
    {
        public SV GetSVByDataRow(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                Name = i["Name"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                DTB = Convert.ToDouble(i["DTB"].ToString()),
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString())
            };
        }
        public List<SV> GetAllSV()
        {
            List<SV> li = new List<SV>();
            string query = "select * from SV";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                li.Add(GetSVByDataRow(i));
            }
            return li;
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> li = new List<LSH>();
            string query = "select * from LSH";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                li.Add(GetLSHByDataRow(i));
            }
            return li;
        }
        public LSH GetLSHByDataRow(DataRow i)
        {
            return new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NameLop = i["NameLop"].ToString()
            };
        }
        public void AddSVDAL(SV s)
        {
            string query = "";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void DelSVDAL(string MSSV)
        {
            string query = "";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateSVDAL(SV s)
        {
            string query = "";
            DBHelper.Instance.ExecuteDB(query);
        }

    }
}

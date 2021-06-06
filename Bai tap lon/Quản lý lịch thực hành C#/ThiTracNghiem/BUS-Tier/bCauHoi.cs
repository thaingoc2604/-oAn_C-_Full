using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DataAccess_Layer;
using System.Collections;


namespace BUS_Tier
{
    public class bCauHoi
    {
        dCauHoi objch = new dCauHoi();

        int time = 0;//thời gian cho câu hỏi này , tính bằng giây
        string noidung = "";//nội dung câu hỏi
        string dapan = "";//đáp án câu hỏi
        string mucdo = "";//mức độ câu hỏi (khó , dễ)
        string dapandung = "";//đáp án đúng (A,B,C,D,E)
        string tinchi = "";//tín chỉ câu hỏi

        #region Set and Get

        public string noi_dung //Lấy hoặc gán nội dung
        {
            get
            {
                return this.noidung;
            }
            set
            {
                this.noidung = value;
            }
        }
        public string dap_an//lấy đáp án hoặc gán đáp án
        {
            get
            {
                return this.dapan;
            }
            set
            {
                this.dapan = value;
            }
        }
        public string muc_do//lấy hoặc gán mức độ
        {
            get
            {
                return this.mucdo;
            }
            set
            {
                this.mucdo = value;
            }
        }
        public string dap_an_dung//lấy hoặc gán đáp án đúng
        {
            get
            {
                return this.dapandung;
            }
            set
            {
                this.dapandung = value;
            }
        }
        public string tin_chi//lấy hoặc gán tín chỉ
        {
            get
            {
                return this.tinchi;
            }
            set
            {
                this.tinchi = value;
            }
        }
        public int time_cauhoi //lấy hoặc gán thời gian
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
        #endregion

        public string tachdapan(int index)
        {
            string[] temp = this.dapan.Split(';');
            return temp[index - 1];
        }
        public int Count_ReCord()
        {
            return objch.Dem_ReCord();
        }
        public int Insert_Question(string noidung, string dapan, string madapan, string mucdo, string tinchi)
        {
            return objch.ThemCauHoi(noidung, dapan, madapan, mucdo, tinchi);
        }
        public int Update_Question(string noidung, string dapan, string madapan, string mucdo, string tinchi, string maq)
        {
            int result = 0;
            result = objch.CapNhatCauHoi(noidung, dapan, madapan, mucdo, tinchi, maq);
            return result;
        }

        public DataTable get_Table_CauHoi_NgauNhien(int songaunhien)
        {
            return objch.get_Table_CauHoi_NgauNhien(songaunhien).Tables["ThuVien"];
        }
    }
}

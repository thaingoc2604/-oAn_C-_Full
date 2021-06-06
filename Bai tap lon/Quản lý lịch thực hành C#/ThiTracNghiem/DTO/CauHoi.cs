using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CauHoi
    {
        public int time = 0;//thời gian cho câu hỏi này , tính bằng giây
        public string noidung = "";//nội dung câu hỏi
        public string dapan = "";//đáp án câu hỏi
        public string mucdo = "";//mức độ câu hỏi (khó , dễ)
        public string dapandung = "";//đáp án đúng (A,B,C,D,E)
        public string tinchi = "";//tín chỉ câu hỏi

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
    }
}

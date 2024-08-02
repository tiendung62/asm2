using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2
{
    public class sinhvien
    {
        public sinhvien(string id, string hoten, string malop, string tenlop, string manv)
        {
            this.id = id;
            this.hoten = hoten;
            this.malop = malop;
            this.tenlop = tenlop;
            this.manv = manv;
        }

        public string id {  get; set; }
        public string hoten { get; set; }
        public string malop { get; set; }
        public string tenlop { get; set; }
        public string manv { get; set; }
    }
}

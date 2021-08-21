using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class SVDAL
    {
        private static SVDAL _Instance;
        public static SVDAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SVDAL();
                return _Instance;
            }
            private set
            {

            }
        }
        public List<SV> GetAllSVDAL()
        {
            Model1 data = new Model1();
            return data.SVs.ToList();
        }
        public List<SV> GetSVByIDLop(int id)
        {
            Model1 data = new Model1();
            List<SV> sv = new List<SV>();
            sv = data.SVs.Where(x => x.ID_Lop == id).ToList();
            return sv;
        }
        public List<SV> GetSVByName(string name)
        {
            Model1 data = new Model1();
            List<SV> sv = new List<SV>();
            sv = data.SVs.Where(x => x.NameSV == name).ToList();
            return sv;
        }
        public List<LSH> GetAllLSHDAL()
        {
            Model1 data = new Model1();
            return data.LSHes.ToList();
        }
        public void AddSV(SV sv)
        {
            Model1 data = new Model1();
            data.SVs.Add(sv);
            data.SaveChanges();
        }
        public void EditSV(SV sv)
        {
            Model1 data = new Model1();
            var oldSV = data.SVs.Find(sv.MSSV);
            oldSV.NameSV = sv.NameSV;
            oldSV.NS = sv.NS;
            oldSV.Gender = sv.Gender;
            oldSV.ID_Lop = sv.ID_Lop;

            data.SaveChanges();
        }
        public void DeleteSV(SV sv)
        {
            Model1 data = new Model1();
            var oldSV = data.SVs.Find(sv.MSSV);
            data.SVs.Remove(oldSV);
            data.SaveChanges();
            
        }
    }
}

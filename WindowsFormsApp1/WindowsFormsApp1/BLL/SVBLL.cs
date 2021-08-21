using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BLL
{
    public class SVBLL
    {
        private static SVBLL _Instance;
        public static SVBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SVBLL();
                return _Instance;
            }
            private set
            {

            }
        }
        public List<SV> ShowSVBLL(int id)
        {
            List<SV> svs = new List<SV>();
            if(id == 0)
            {
                svs = SVDAL.Instance.GetAllSVDAL();
            }
            else
            {
                svs = SVDAL.Instance.GetSVByIDLop(id);
            }
            return svs;
             
        }
        public List<SV> SearchBLL(string name)
        {
            List<SV> svs = new List<SV>();
            if (name == "")
            {
                svs = SVDAL.Instance.GetAllSVDAL();
            }
            else
            {
                svs = SVDAL.Instance.GetSVByName(name);
            }
            return svs;
        }
        public List<SV> ShowALLSVBLL()
        {
            return SVDAL.Instance.GetAllSVDAL();
        }
        public void AddSVBLL(SV sv)
        {
            SVDAL.Instance.AddSV(sv);
        }
        public void EditSVBLL(SV sv)
        {
            SVDAL.Instance.EditSV(sv);
        }
        public void DeleteSVBLL(SV sv)
        {
            SVDAL.Instance.DeleteSV(sv);
        }
        public List<SV> SortSV(string ColumnName)
        {
            List<SV> sv = ShowALLSVBLL();
            for (int i = 0; i < sv.Count; i++)
            {
                for (int j = 0; j < sv.Count; j++)
                {
                    switch (ColumnName)
                    {
                        case "MSSV":
                            {
                                if (String.Compare(sv[i].MSSV, sv[j].MSSV) > 0)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                        case "NameSV":
                            {
                                if (String.Compare(sv[i].NameSV, sv[j].NameSV) > 0)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                        case "NS":
                            {
                                if (DateTime.Compare(sv[i].NS, sv[j].NS) > 0)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                        case "ID_Lop":
                            {
                                if (sv[i].ID_Lop > sv[j].ID_Lop)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                    }
                }
            }
            return sv;
        }
    }
    
}

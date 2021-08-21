using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class CreateDB : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 context)
        {
            context.LSHes.AddRange(new LSH[]
            {
                new LSH{ID_Lop = 1,NameLop = "19TCLC-DT1"},
                new LSH{ID_Lop = 2,NameLop = "19TCLC-DT2"},
                new LSH{ID_Lop = 3,NameLop = "19TCLC-DT3"}
            });
            context.SVs.AddRange(new SV[]
            {
                new SV{MSSV = "101" ,NameSV = "NVA",NS = DateTime.Parse("07/12/2001"),Gender = true,ID_Lop = 1 },
                new SV{MSSV = "102" ,NameSV = "NVB",NS = DateTime.Parse("07/12/2001"),Gender = true,ID_Lop = 2 },
                new SV{MSSV = "103" ,NameSV = "NVC",NS = DateTime.Parse("07/12/2001"),Gender = true,ID_Lop = 3 },
            });
        }
    }
}

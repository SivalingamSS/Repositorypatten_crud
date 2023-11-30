using Repoistorypattern_DTO.student_details_viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IdatalayerInterface
    {
        public object get();
        public object Postvalue(Employee see);
        public object putvalue(int id, viewmodel can);
        public object deletevalue(int Id);

    }
}

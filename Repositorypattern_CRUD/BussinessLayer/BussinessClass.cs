using DataLayer;
using Repoistorypattern_DTO.student_details_viewmodel;
using System.Xml.Linq;

namespace BussinessLayer
{
    public class BussinessClass : IbussinessInterface
    {
        public readonly IdatalayerInterface _datalayerInterface;
        public BussinessClass(IdatalayerInterface datalayerInterface)
        {
            _datalayerInterface = datalayerInterface;
        }

        public object get()
        {
            var get = _datalayerInterface.get();
            return get;
        }
        public object Postvalue(Employee see)
        {
            var res = _datalayerInterface.Postvalue(see);
            return res;

        }
        public object putvalue(int id, viewmodel can)
        {
            var update = _datalayerInterface.putvalue(id, can);
            return update;
        }
        public object deletevalue(int Id)
        {
            var delete = _datalayerInterface.deletevalue(Id);
            return delete;

        }

    }
} 
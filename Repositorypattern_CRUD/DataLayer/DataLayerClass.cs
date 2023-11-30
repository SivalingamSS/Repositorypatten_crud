using Repoistorypattern_DTO.Dbcontact;
using Repoistorypattern_DTO.student_details_viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataLayerClass : IdatalayerInterface
    {
        private readonly Dbcontext _employee;
        public DataLayerClass(Dbcontext employee1)
        {
            _employee = employee1;
        }

        public object get()
        {
            var det = _employee.Studentsiva.ToList();
            return det;
        }

        public object Postvalue(Employee see)
        {
            var rep = new Employee()
            {
                Id = see.Id,
                Name = see.Name,
                age = see.age,
                address = see.address,

            };
            _employee.Studentsiva.AddAsync(rep);
            _employee.SaveChangesAsync();
            return rep;
        }

        public object putvalue(int id, viewmodel can)
        {
            var rep = _employee.Studentsiva.Find(id);
            if (rep != null)
            {
                rep.age = can.age;
                rep.address = can.address;
                rep.Name = can.Name;
                _employee.SaveChangesAsync();
                return (rep);
            }
            return 0;

        }
        public object deletevalue(int Id)
        {
            var rep = _employee.Studentsiva.Find(Id);
            if (rep != null)
            {
                _employee.Studentsiva.Remove(rep);
                _employee.SaveChanges();
                return (rep);
            }
            return 0;
        }
    }
}

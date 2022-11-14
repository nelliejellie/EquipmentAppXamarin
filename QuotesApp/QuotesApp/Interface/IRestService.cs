using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp.Interface
{
    public interface IRestService
    {
        Task<List<Equipment>> GetEquipments();
        Task<List<Student>> GetStudents();
        Task<bool> PostEquipment(Equipment equipment);
    }
}

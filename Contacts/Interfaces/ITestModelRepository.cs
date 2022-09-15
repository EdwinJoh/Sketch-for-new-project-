using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Interfaces
{
    public interface ITestModelRepository
    {
        Task< IEnumerable<TestModel>> GetAllTestModels(bool trackChanges);
        Task <TestModel> GetTestModel(int id,bool trackChanges);
    }
}

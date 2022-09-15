using Contacts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TestModelRepository : RepositoryBase<TestModel>, ITestModelRepository
    {
        public TestModelRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<TestModel>> GetAllTestModels(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(x => x.Name)
            .ToList();
        public async Task<TestModel> GetTestModel(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefault();

    }
}

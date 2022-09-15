using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Interfaces
{
    public interface IRepositoryManager
    {
        ITestModelRepository TestModel { get; }
        void Save();
    }
}

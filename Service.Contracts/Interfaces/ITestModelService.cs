﻿using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Interfaces;

public interface ITestModelService
{
    Task<IEnumerable<TestModelDto>> GetTestModels(bool trackChanges);
    Task<TestModelDto> GetTestModel(int id, bool trackChanges);
}

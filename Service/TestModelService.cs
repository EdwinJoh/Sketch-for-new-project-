using AutoMapper;
using Contacts.Interfaces;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service;

internal sealed class TestModelService : ITestModelService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    public TestModelService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }
    public async Task<IEnumerable<TestModelDto>> GetTestModels(bool trackChanges)
    {
        var testModels = _repository.TestModel.GetAllTestModels(trackChanges);

        var testModelDto = _mapper.Map<IEnumerable<TestModelDto>>(testModels);

        return testModelDto;

    }
    public async Task<TestModelDto> GetTestModel(int id, bool trackChanges)
    {
        var testModel = _repository.TestModel.GetTestModel(id, trackChanges);
        if (testModel == null)
            throw new TestModelNotFoundException(id);

        var testDto = _mapper.Map<TestModelDto>(testModel);

        return testDto;
    }


}

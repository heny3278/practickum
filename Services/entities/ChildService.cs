using AutoMapper;
using Common.DTOs;
using repositories.entities;
using repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.entities
{
    public class ChildService : IService<ChildDTO>
    {
        private readonly IMapper _mapper;
        private readonly IDataRepository<Child> _childRepository;

        public ChildService(IMapper mapper, IDataRepository<Child> childRepository)
        {
            _mapper = mapper;
            _childRepository = childRepository;
        }

        public async Task<ChildDTO> Add(ChildDTO entity)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.Add(_mapper.Map<Child>(entity)));
        }

        

        public async Task<List<ChildDTO>> GetAll()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAll());
        }

        public async Task<ChildDTO> GetById(int id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetById(id));
        }

      
    }
}

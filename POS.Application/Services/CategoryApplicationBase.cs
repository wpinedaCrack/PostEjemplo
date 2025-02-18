using AutoMapper;
using POS.Infraestructure.Persistences.Interfaces;

namespace POS.Application.Services
{
    internal class CategoryApplicationBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfwork _unitOfwork;
        //private readonly CategoryValidator _validationRules;
    }
}

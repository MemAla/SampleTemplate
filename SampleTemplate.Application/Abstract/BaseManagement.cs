using SampleTemplate.EntityFramework.Abstract;

namespace SampleTemplate.Application.Abstract
{
    public class BaseManagement
    {
        public readonly IUnitOfWork _unitOfWork;
        public BaseManagement(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}

using FluentValidation;
using NLayer.Core.DTOs;

namespace NLayer.Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("{PropertyName} is required!").NotEmpty().WithMessage("{PropertyName} is required!");
            RuleFor(p => p.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0!");
            RuleFor(p => p.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0!");
        }
    }
}

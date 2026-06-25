using FluentValidation;
using Products.Application.Features.Products.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Application.Features.Products.Validators
{
    public class CreateProductCommandValidator
    : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Price)
                .GreaterThan(0);

            RuleFor(x => x.Stock)
                .GreaterThanOrEqualTo(0);
        }
    }
}

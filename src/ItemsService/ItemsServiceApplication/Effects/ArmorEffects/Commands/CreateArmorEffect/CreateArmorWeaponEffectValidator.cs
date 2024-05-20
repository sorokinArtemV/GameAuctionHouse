﻿using FluentValidation;

namespace ItemsService.ItemsServiceApplication.Effects.ArmorEffects.Commands.CreateArmorEffect;

public class CreateArmorEffectCommandValidator : AbstractValidator<CreateArmorEffectCommand>
{
    public CreateArmorEffectCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .Length(3, 100)
            .WithMessage("Name must be between 3 and 100 characters");
        RuleFor(x => x.Description)
            .NotEmpty()
            .Length(3, 100)
            .WithMessage("Description must be between 3 and 100 characters");

        RuleFor(x => x.Charges)
            .GreaterThan(0)
            .WithMessage("Charges must be greater than 0");

        RuleFor(x => x.Duration).GreaterThan(TimeSpan.Zero)
            .WithMessage("Duration must be greater than 0 and has format: HH:mm:ss");
    }
}
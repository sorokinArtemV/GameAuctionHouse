﻿using ItemsService.ItemServiceCore.Entities.ItemTypes;
using ItemsService.ItemServiceCore.Exceptions;
using ItemsService.ItemServiceCore.RepositoryContracts;
using MediatR;
using Serilog;

namespace ItemsService.ItemsServiceApplication.Weapons.Commands.DeleteWeapon;

public class DeleteWeaponCommandHandler(
    ILogger<DeleteWeaponCommandHandler> logger,
    IGenericRepository<Weapon> repository,
    IDiagnosticContext diagnosticContext
) : IRequestHandler<DeleteWeaponCommand>
{
    public async Task Handle(DeleteWeaponCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Deleting weapon with id {Id}", request.Id);

        var weapon = await repository.GetByIdAsync(request.Id);

        if (weapon is null) throw new NotFoundException(nameof(Weapon), request.Id.ToString());

        await repository.DeleteAsync(weapon);

        diagnosticContext.Set("Weapon deleted", weapon);
    }
}
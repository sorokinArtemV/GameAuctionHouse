﻿using ItemsService.ItemsServiceApplication.Weapons.DTO;

namespace ItemsService.ItemsServiceApplication.Weapons;

public interface IWeaponsService
{
    Task<IEnumerable<WeaponDto>> GetAllAsync();
    Task<WeaponDto?> GetByIdAsync(int id);
    Task<int> CreateAsync(CreateWeaponDto createWeaponDto);
}
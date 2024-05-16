﻿namespace ItemsService.ItemsServiceApplication.Effects.Dto;

public class EffectDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int Charges { get; set; }
    public TimeSpan Duration { get; set; }
    public bool IsPassive { get; set; }
    
    public int? WeaponId { get; set; }
    
    public int? ArmorId { get; set; }
}
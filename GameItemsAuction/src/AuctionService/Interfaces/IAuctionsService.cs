﻿using AuctionService.DTO;

namespace AuctionService.Interfaces;

public interface IAuctionsService
{
    public Task<IEnumerable<AuctionDto>> GetAllAuctions(string? date);
    public Task<AuctionDto> GetAuctionById(Guid auctionId);
    public Task<AuctionDto> CreateAuction(CreateAuctionDto auctionDto);
    public Task DeleteAuction(Guid auctionId);
}
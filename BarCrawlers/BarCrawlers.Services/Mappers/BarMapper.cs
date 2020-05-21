﻿using BarCrawlers.Data.DBModels;
using BarCrawlers.Services.DTOs;
using BarCrawlers.Services.Mappers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarCrawlers.Services.Mappers
{
    public class BarMapper : IBarMapper
    {
        public Bar MapDTOToEntity(BarDTO dto)
        {
            try
            {
                return new Bar
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Rating = dto.Rating,
                    TimesRated = dto.TimesRated,
                    ImageSrc = dto.ImageSrc,
                    IsDeleted = dto.IsDeleted,
                    Address = dto.Address,
                    Country = dto.Country,
                    District = dto.District,
                    Email = dto.Email,
                    LocationId = dto.LocationId,
                    Phone = dto.Phone,
                    Town = dto.Town
                };
            }
            catch (Exception)
            {
                return new Bar();
            }
        }

        public BarDTO MapEntityToDTO(Bar entity)
        {
            try
            {
                return new BarDTO
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Rating = entity.Rating,
                    TimesRated = entity.TimesRated,
                    ImageSrc = entity.ImageSrc,
                    IsDeleted = entity.IsDeleted,
                    Address = entity.Address,
                    Country = entity.Country,
                    District = entity.District,
                    Email = entity.Email,
                    LocationId = entity.LocationId,
                    Phone = entity.Phone,
                    Town = entity.Town
                };
            }
            catch (Exception)
            {
                return new BarDTO();
            }
        }
    }
}

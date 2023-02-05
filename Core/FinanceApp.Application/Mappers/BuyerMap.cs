using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FinanceApp.Application.Features.Buyer.Commands;
using FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Mappers
{
    public class BuyerMap : Profile
    {
        public BuyerMap()
        {
            CreateMap<Buyer, CreateBuyerCommandRequest>().ReverseMap();
        }
    }
}

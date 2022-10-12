using AutoMapper;
using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<About, AboutDTO>();
            CreateMap<AboutDTO, About>();

            CreateMap<Color, ColorDTO>();
            CreateMap<ColorDTO, Color>();

            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, Contact>();

            CreateMap<Currency, CurrencyDTO>();
            CreateMap<CurrencyDTO, Currency>();

            CreateMap<MarkaClassic, MarkaClassicDTO>();
            CreateMap<MarkaClassicDTO, MarkaClassic>();

            CreateMap<MarkaDiscount, MarkaDiscountDTO>();
            CreateMap<MarkaDiscountDTO, MarkaDiscount>();

            CreateMap<MarkaSport, MarkaSportDTO>();
            CreateMap<MarkaSportDTO, MarkaSport>();

            CreateMap<MarkaStyle, MarkaStyleDTO>();
            CreateMap<MarkaStyleDTO, MarkaStyle>();

            CreateMap<Message, MessageDTO>();
            CreateMap<MessageDTO, Message>();

            CreateMap<Reklam, ReklamDTO>();
            CreateMap<ReklamDTO, Reklam>();

            CreateMap<ShoeClassic, ShoeClassicDTO>()
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(x => x.Currency.CurrencyName));
            CreateMap<ShoeClassicDTO, ShoeClassic>();

            CreateMap<ShoeDiscount, ShoeDiscountDTO>()
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(x => x.Currency.CurrencyName));
            CreateMap<ShoeDiscountDTO, ShoeDiscount>();

            CreateMap<ShoeSport, ShoeSportDTO>()
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(x => x.Currency.CurrencyName));
            CreateMap<ShoeSportDTO, ShoeSport>();

            CreateMap<ShoeStyle, ShoeStyleDTO>()
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(x => x.Currency.CurrencyName));
            CreateMap<ShoeStyleDTO, ShoeStyle>();

            CreateMap<Size, SizeDTO>();
            CreateMap<SizeDTO, Size>();

            CreateMap<SocialMedia, SocialMediaDTO>();
            CreateMap<SocialMediaDTO, SocialMedia>();
        }
    }
}

using AutoMapper;
using BigData.Domain.DTos;
using BigData.Domain.Entities;
using System;
using System.Text.RegularExpressions;

namespace BigData.Service.Mappers
{
    public class PessoaMapper : Profile
    {
        public PessoaMapper()
        {
            CreateMap<PessoaDto, Pessoa>()
                .ForMember(dest => dest.DataInsercao, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.Cpf, opt => opt.MapFrom(src => Regex.Replace(src.Cpf, @"[.-]", "")));

            CreateMap<EnderecoDto, Endereco>();

            CreateMap<TelefoneDto, Telefone>();
            
        }
    }
}

﻿namespace Business.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<AutoVM, Auto>().ReverseMap();
		}
	}
}

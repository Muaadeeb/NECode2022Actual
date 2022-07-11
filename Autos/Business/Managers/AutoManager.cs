using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.EntityFrameworkCore;
using ViewModels;

namespace Business.Managers
{
	public class AutoManager : IAutoManager
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public AutoManager(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<AutoVM> CreateAsync(AutoVM obj)
		{
			var auto = _mapper.Map<AutoVM, Auto>(obj);
			var autoAdded = await _context.Autos.AddAsync(auto);
			await _context.SaveChangesAsync();
			return _mapper.Map<Auto, AutoVM>(autoAdded.Entity);
		}

		public async Task<AutoVM> UpdateAsync(AutoVM obj)
		{
			var autoInfo = await _context.Autos.FindAsync(obj.Id);
			var autoMapped = _mapper.Map<AutoVM, Auto>(obj, autoInfo!);

			var updatedAuto = _context.Autos.Update(autoMapped);
			await _context.SaveChangesAsync();

			return _mapper.Map<Auto, AutoVM>(updatedAuto.Entity);
		}

		public async Task<int> DeleteAsync(int id)
		{
			var autoInfo = await _context.Autos.FindAsync(id);
			if (autoInfo != null)
			{
				_context.Autos.Remove(autoInfo);
				return await _context.SaveChangesAsync();
			}

			return default;

		}

		public async Task<AutoVM> GetAsync(int id)
		{
			var autoInfo = await _context.Autos.FirstOrDefaultAsync((x => x.Id == id));

			if (autoInfo == null)
			{
				//return new();
				return null!;
			}

			return _mapper.Map<Auto, AutoVM>(autoInfo);

		}

		public async Task<IEnumerable<AutoVM>> GetAllAsync()
		{
			return _mapper.Map<IEnumerable<Auto>, IEnumerable<AutoVM>>(await _context.Autos.ToListAsync());
		}
	}
}

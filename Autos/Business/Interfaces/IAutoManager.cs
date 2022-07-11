using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Business.Interfaces
{
	public interface IAutoManager
	{
		public Task<AutoVM> CreateAsync(AutoVM obj);
		public Task<AutoVM> UpdateAsync(AutoVM obj);
		public Task<int> DeleteAsync(int id);
		public Task<AutoVM> GetAsync(int id);
		public Task<IEnumerable<AutoVM>> GetAllAsync();
	}
}

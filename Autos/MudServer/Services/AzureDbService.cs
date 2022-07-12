using MudServer.Services.Interfaces;

namespace MudServer.Services
{
	public class AzureDbService : IAzureDbService
	{
		private readonly ApplicationDbContext _context;

		public AzureDbService(ApplicationDbContext context)
		{
			_context = context;
		}

		public void Initialize()
		{
			try
			{
				if (_context.Database.GetPendingMigrations().Any())
				{
					_context.Database.Migrate();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
	}
}

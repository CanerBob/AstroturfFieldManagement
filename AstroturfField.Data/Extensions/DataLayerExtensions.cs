namespace AstroturfField.Data.Extensions;
public static class DataLayerExtensions
{
	public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultCon")));
		return services;
	}
}
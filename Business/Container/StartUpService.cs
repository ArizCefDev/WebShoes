using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Container
{
    public static class StartUpService
    {
        public static void ContainerServices(this IServiceCollection services)
        {
            services.AddScoped<IShoeDiscountService, ShoeDiscountService>();
            services.AddScoped<IMarkaDiscountService, MarkaDiscountService>();

            services.AddScoped<IShoeSportService, ShoeSportService>();
            services.AddScoped<IMarkaSportService, MarkaSportService>();

            services.AddScoped<IMarkaClassicService, MarkaClassicService>();

            services.AddScoped<IShoeStyleService, ShoeStyleService>();
            services.AddScoped<IMarkaStyleService, MarkaStyleService>();

            services.AddScoped<IColorService, ColorService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<ISizeService, SizeService>();

        }
    }
}

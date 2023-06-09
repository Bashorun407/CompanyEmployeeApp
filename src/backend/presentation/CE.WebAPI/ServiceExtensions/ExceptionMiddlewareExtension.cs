using CE.Application.Common;

namespace CE.WebAPI.ServiceExtensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerManager logger)
        {
            app.UseExceptionHandler(appError => { });
        }
    }
}

using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MauiBugButtonRenderer;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.UseMauiCompatibility()
			.ConfigureMauiHandlers(handlers =>
			{
#if ANDROID
				handlers.AddCompatibilityRenderer(typeof(MyButton), typeof(MauiBugButtonRenderer.Platforms.Android.MyButtonRenderer));
#endif

#if WINDOWS
				// If the following line is deleted, no custom renderer is used in Windows and the buttons have
				// the correct width.
                handlers.AddCompatibilityRenderer(typeof(MyButton), typeof(MauiBugButtonRenderer.Platforms.Windows.MyButtonRenderer));
#endif
            });

		return builder.Build();
	}
}

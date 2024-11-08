using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
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
                    fonts.AddFont("ConcertOne-Regular.ttf", "ConcertOneRegular");
                    fonts.AddFont("RobotoSlab-Black.ttf", "RobotoSlabBlack");
                    fonts.AddFont("RobotoSlab-Bold.ttf", "RobotoSlabBold");
                    fonts.AddFont("RobotoSlab-ExtraBold.ttf", "RobotoSlabExtraBold");
                    fonts.AddFont("RobotoSlab-ExtraLight.ttf", "RobotoSlabExtraLight");
                    fonts.AddFont("RobotoSlab-Light.ttf", "RobotoSlabLight");
                    fonts.AddFont("RobotoSlab-Medium.ttf", "RobotoSlabMedium");
                    fonts.AddFont("RobotoSlab-Regular.ttf", "RobotoSlab");
                    fonts.AddFont("RobotoSlab-SemiBold.ttf", "RobotoSlabSemiBold");
                    fonts.AddFont("RobotoSlab-Thin.ttf", "RobotoSlabThin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

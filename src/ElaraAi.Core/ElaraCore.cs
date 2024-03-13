using ElaraAi.Core.Services;

namespace ElaraAi.Core;

public class ElaraCore : IElaraCore
{
    public IFileManager FileManager { get; }
    public ISettingsManager SettingsManager { get; }
    public IUserProfileManager UserProfileManager { get; }
    public IDataManager DataManager { get; }
    public ElaraCore()
    {
        FileManager = new FileManager();
        SettingsManager = new SettingsManager();
        UserProfileManager = new UserProfileManager();
        DataManager = new DataManager();
    }
}
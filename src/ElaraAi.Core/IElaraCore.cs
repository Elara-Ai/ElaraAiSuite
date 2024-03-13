using ElaraAi.Core.Services;

namespace ElaraAi.Core;

public interface IElaraCore
{
    public IFileManager FileManager { get; }
    public ISettingsManager SettingsManager { get; }
    public IUserProfileManager UserProfileManager { get; }
}
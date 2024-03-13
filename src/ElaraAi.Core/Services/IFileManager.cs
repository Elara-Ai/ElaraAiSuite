namespace ElaraAi.Core.Services;

public interface IFileManager
{
    public string ProgramDataPath { get; }
    public string ElaraAiPath { get; }
    public string LogPath { get; }
    public string LogFilePath { get; }
    public string SettingsPath { get; }
    public string SettingsFilePath { get; }
}
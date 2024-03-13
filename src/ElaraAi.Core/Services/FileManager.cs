using System.Text.Json;
using ElaraAi.Common;
using ElaraAi.Core.Models;
using Microsoft.VisualBasic;

namespace ElaraAi.Core.Services;

public class FileManager : IFileManager
{
    public FileManager()
    {
        EnsureDirectoriesExist(ProgramDataPath);
        EnsureDirectoriesExist(ElaraAiPath);
        EnsureDirectoriesExist(LogPath);
        EnsureDirectoriesExist(SettingsFilePath);
        
        EnsureFileExists(LogFilePath);
        EnsureFileExists(SettingsFilePath, JsonSerializer.Serialize(new AppSettings()));;
    }

    public string ProgramDataPath => AppConstants.ProgramData;
    public string ElaraAiPath => Path.Combine(ProgramDataPath, AppConstants.ElaraAi);
    
    public string LogPath => Path.Combine(ElaraAiPath, "logs");
    public string LogFilePath => Path.Combine(LogPath, "elaraai.log");
    public string SettingsPath => Path.Combine(ElaraAiPath, "settings");
    public string SettingsFilePath => Path.Combine(SettingsPath, "elaraai.json");
    
    

    private void EnsureDirectoriesExist(string p_path)
    {
        if (!Directory.Exists(p_path))
        {
            Directory.CreateDirectory(p_path);
            Console.WriteLine($"Created directory: {p_path}");
        }
        
    }

    private void EnsureFileExists(string p_path, string? p_content = null)
    {
        if (!File.Exists(p_path))
        {
            File.Create(p_path);
            Console.WriteLine($"Created file: {p_path}");
            if (p_content != null) File.WriteAllText(p_path, p_content);
        }

    }
    
    
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace _321_MediaPlayer
{
    /// <summary>
    /// Configuration locale de l'application (dossier média choisi au premier lancement).
    /// </summary>
    internal static class AppSettings
    {
        private static readonly string SettingsDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "321-MediaPlayer");

        private static readonly string SettingsPath = Path.Combine(SettingsDirectory, "settings.json");

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        /// <summary>
        /// Dossier média enregistré (null tant que l'utilisateur n'a rien choisi).
        /// </summary>
        public static string? MediaFolder { get; private set; }

        /// <summary>
        /// Vrai si un dossier a été enregistré et existe encore sur le disque.
        /// </summary>
        public static bool HasLibrary =>
            !string.IsNullOrWhiteSpace(MediaFolder) && Directory.Exists(MediaFolder);

        static AppSettings()
        {
            Load();
        }

        private static void Load()
        {
            try
            {
                if (!File.Exists(SettingsPath))
                {
                    return;
                }

                using JsonDocument document = JsonDocument.Parse(File.ReadAllText(SettingsPath));

                if (document.RootElement.ValueKind == JsonValueKind.Object &&
                    document.RootElement.TryGetProperty("mediaFolder", out JsonElement folder) &&
                    folder.ValueKind == JsonValueKind.String)
                {
                    string? value = folder.GetString();
                    MediaFolder = string.IsNullOrWhiteSpace(value) ? null : value;
                }
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or JsonException)
            {
                Debug.WriteLine($"Lecture de la configuration impossible : {ex.Message}");
                MediaFolder = null;
            }
        }

        /// <summary>
        /// Mémorise le dossier média pour les prochains démarrages.
        /// </summary>
        public static void SaveMediaFolder(string folder)
        {
            MediaFolder = folder;

            try
            {
                Directory.CreateDirectory(SettingsDirectory);

                string json = JsonSerializer.Serialize(
                    new Dictionary<string, string> { ["mediaFolder"] = folder },
                    JsonOptions);

                File.WriteAllText(SettingsPath, json);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                Debug.WriteLine($"Écriture de la configuration impossible : {ex.Message}");
            }
        }
    }
}

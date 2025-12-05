using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace De_Gibrify
{
 public class HotkeyConfig
 {
 public string Key { get; set; } = "F10";
 public List<string> Modifiers { get; set; } = new List<string> { "Alt" };
 public List<string> Languages { get; set; } = new List<string> { "en-US", "he-IL" };

 [JsonIgnore]
 public static string ConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hotkey.json");

 public static HotkeyConfig LoadOrCreateDefault()
 {
 try
 {
 if (File.Exists(ConfigPath))
 {
 var text = File.ReadAllText(ConfigPath);
 var cfg = JsonSerializer.Deserialize<HotkeyConfig>(text);
 if (cfg != null)
 return cfg;
 }
 }
 catch
 {
 // ignore and recreate default
 }

 var def = new HotkeyConfig();
 try
 {
 var opts = new JsonSerializerOptions { WriteIndented = true };
 File.WriteAllText(ConfigPath, JsonSerializer.Serialize(def, opts));
 }
 catch
 {
 // ignore write failures
 }
 return def;
 }

 public int GetModifierMask()
 {
 int mask =0;
 foreach (var m in Modifiers.Select(x => x?.Trim()).Where(x => !string.IsNullOrEmpty(x)))
 {
 switch (m!.ToLowerInvariant())
 {
 case "alt": mask |=0x0001; break; // MOD_ALT
 case "control":
 case "ctrl": mask |=0x0002; break; // MOD_CONTROL
 case "shift": mask |=0x0004; break; // MOD_SHIFT
 case "win":
 case "windows": mask |=0x0008; break; // MOD_WIN
 }
 }
 return mask;
 }

 public int GetVirtualKey()
 {
 if (Enum.TryParse<Keys>(Key, true, out var k))
 return (int)k;

 // Try single char
 if (!string.IsNullOrEmpty(Key) && Key.Length ==1)
 {
 char c = Key[0];
 var vk = (int)Keys.None;
 if (char.IsLetterOrDigit(c))
 {
 var name = c.ToString().ToUpperInvariant();
 if (Enum.TryParse<Keys>(name, out var kk))
 {
 vk = (int)kk;
 }
 }
 if (vk != (int)Keys.None)
 return vk;
 }

 // Fallback
 return (int)Keys.F10;
 }
 }
}

using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using HarmonyLib;
using Reactor;

namespace ModPack
{
    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public class ModPack : BasePlugin
    {
        public static bool debug = true;

        public const string Id = "org.bepinex.plugins.ModPack";
        public static BepInEx.Logging.ManualLogSource log;

        public static bool introDone = false;

        public Harmony Harmony { get; } = new Harmony(Id);

        public ConfigEntry<string> Name { get; private set; }

        public override void Load()
        {
            log = Log;
            log.LogMessage("Mod Pack Loaded");

            Harmony.PatchAll();
        }        
    }
}

using BepInEx;
using BepInEx.Logging;
using BetterConductor.Patches;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterConductor
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class BetterConductor: BaseUnityPlugin
    {
        private const string modGUID = "Erabior.BetterConductor";

        private const string modName = "Better Conductor Mod";

        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static BetterConductor Instance;

        internal ManualLogSource mls;
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Loaded Better Conductor");

            harmony.PatchAll(typeof(BetterConductor));
            harmony.PatchAll(typeof(AutoEngineerPATCH));

        }
    }
}

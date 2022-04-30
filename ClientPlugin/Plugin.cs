using System;
using System.IO;
using ClientPlugin.GUI;
using HarmonyLib;
using Sandbox.Graphics.GUI;
using Shared.Config;
using Shared.Logging;
using Shared.Patches;
using Shared.Plugin;
using VRage.FileSystem;
using VRage.Plugins;

namespace ClientPlugin
{
    // ReSharper disable once UnusedType.Global
    public class Plugin : IPlugin, ICommonPlugin
    {
        public const string Name = "PluginTemplate";
        public static Plugin Instance { get; private set; }

        public long Tick { get; private set; }

        public IPluginLogger Log => Logger;
        private static readonly IPluginLogger Logger = new PluginLogger(Name);

        public IPluginConfig Config => config?.Data;
        private PersistentConfig<PluginConfig> config;
        private static readonly string ConfigFileName = $"{Name}.cfg";

        private static bool initialized;
        private static bool failed;

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public void Init(object gameInstance)
        {
            Instance = this;

            Log.Info("Loading");

            var configPath = Path.Combine(MyFileSystem.UserDataPath, ConfigFileName);
            config = PersistentConfig<PluginConfig>.Load(Log, configPath);

            Common.SetPlugin(this);

            if (!PatchHelpers.HarmonyPatchAll(Log, new Harmony(Name)))
            {
                failed = true;
                return;
            }

            Log.Debug("Successfully loaded");
        }

        public void Dispose()
        {
            try
            {
                // TODO: Save state and close resources here, called when the game exists (not guaranteed!)
                // IMPORTANT: Do NOT call harmony.UnpatchAll() here! It may break other plugins.
            }
            catch (Exception ex)
            {
                Log.Critical(ex, "Dispose failed");
            }

            Instance = null;
        }

        public void Update()
        {
            EnsureInitialized();
            try
            {
                if (!failed)
                {
                    CustomUpdate();
                    Tick++;
                }
            }
            catch (Exception ex)
            {
                Log.Critical(ex, "Update failed");
                failed = true;
            }
        }

        private void EnsureInitialized()
        {
            if (initialized || failed)
                return;

            Log.Info("Initializing");
            try
            {
                Initialize();
            }
            catch (Exception ex)
            {
                Log.Critical(ex, "Failed to initialize plugin");
                failed = true;
                return;
            }

            Log.Debug("Successfully initialized");
            initialized = true;
        }

        private void Initialize()
        {
            #region Cache        
            try
            {
                DirectoryInfo directoryInfoCache = new DirectoryInfo(MyFileSystem.CachePath);

                foreach (FileInfo file in directoryInfoCache.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfoCache.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region IngameScriptsTemp
            try
            {
                DirectoryInfo directoryInfoIngameScriptsTemp = new DirectoryInfo(Path.Combine(MyFileSystem.CachePath, "..\\IngameScripts\\temp"));

                foreach (FileInfo file in directoryInfoIngameScriptsTemp.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfoIngameScriptsTemp.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region ProfileOptimization
            try
            {
                DirectoryInfo directoryInfoProfileOptimization = new DirectoryInfo(Path.Combine(MyFileSystem.UserDataPath, "ProfileOptimization"));

                foreach (FileInfo file in directoryInfoProfileOptimization.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfoProfileOptimization.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region Promo
            try
            {
                DirectoryInfo directoryInfoPromo = new DirectoryInfo(Path.Combine(MyFileSystem.UserDataPath, "Promo"));

                foreach (FileInfo file in directoryInfoPromo.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfoPromo.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region ShaderCache2
            try
            {
                DirectoryInfo directoryInfoShaderCache2 = new DirectoryInfo(Path.Combine(MyFileSystem.UserDataPath, "ShaderCache2"));

                foreach (FileInfo file in directoryInfoShaderCache2.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfoShaderCache2.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region temp
            try
            {
                DirectoryInfo directoryInfotemp = new DirectoryInfo(Path.Combine(MyFileSystem.UserDataPath, "temp"));

                foreach (FileInfo file in directoryInfotemp.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfotemp.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region WorkshopBrowser
            try
            {
                DirectoryInfo directoryInfoWorkshopBrowser = new DirectoryInfo(Path.Combine(MyFileSystem.UserDataPath, "WorkshopBrowser"));

                foreach (FileInfo file in directoryInfoWorkshopBrowser.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfoWorkshopBrowser.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region GPUCache
            try
            {
                DirectoryInfo directoryInfoGPUCache = new DirectoryInfo(Path.Combine(MyFileSystem.ExePath, "GPUCache"));

                foreach (FileInfo file in directoryInfoGPUCache.EnumerateFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        continue;
                    }

                }
                foreach (DirectoryInfo dir in directoryInfoGPUCache.EnumerateDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion

            try
            {
                File.Delete(Path.Combine(MyFileSystem.UserDataPath, "mipMapTextureCache2.B5"));
            }
            catch (Exception)
            {

            }
            try
            {
                foreach (string sFile in Directory.GetFiles(MyFileSystem.UserDataPath, "*.log"))
                {
                    try
                    {
                        File.Delete(sFile);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void CustomUpdate()
        {
            // TODO: Put your update code here. It is called on every simulation frame!
        }


        // ReSharper disable once UnusedMember.Global
        public void OpenConfigDialog()
        {
            MyGuiSandbox.AddScreen(new MyPluginConfigDialog());
        }
    }
}
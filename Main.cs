using System;
using System.IO;
using VRage.FileSystem;
using VRage.Plugins;

namespace FileCleaner
{
    public class Main : IPlugin
    {
        public void Dispose()
        {
            
        }

        public void Init(object gameInstance)
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

        public void Update()
        {
            
        }
    }
}

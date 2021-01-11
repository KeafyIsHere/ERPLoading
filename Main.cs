using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ERPLoading
{
    public class Main : MelonLoader.MelonMod
    {
        private AssetBundle bl { get; set; }
        public override void OnApplicationStart()
        {
            bl = AssetBundle.LoadFromMemory(Properties.Resources.erp);
        }
        public override void OnLevelWasLoaded(int level)
        {
            try
            {
                GameObject.DestroyImmediate(GameObject.Find("/UserInterface/MenuContent/Screens/Title/LogoContainer/vrchatlogo2sided"));
                GameObject.Instantiate(bl.LoadAsset<GameObject>("ERP ANimation Variant"), GameObject.Find("/UserInterface/MenuContent/Screens/Title/LogoContainer").transform);
            }
            catch { }
        }
    }
}

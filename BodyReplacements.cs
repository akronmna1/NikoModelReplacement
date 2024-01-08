using ModelReplacement;
using UnityEngine;

namespace niko
{
    public class MRNIKO : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "niko";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void AddModelScripts()
        {
           
        }

    }
}
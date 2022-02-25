using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.IO;

public class LoadAssetBundle : MonoBehaviour
{

    //private void Start()
    //{
    //    var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "mynewasset"));
    //    if (myLoadedAssetBundle == null)
    //    {
    //        Debug.Log("Failed to load AssetBundle!");
    //        return;
    //    }
    //    var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("Sphere");
    //    Instantiate(prefab);
    //}

    public string bundleUrl = "http://localhost/assetbundles/testbundle";
    public string assetName = "BundledObject";

    // Start is called before the first frame update
    //IEnumerator Start()
    //{
    //    using (WWW web = new WWW(bundleUrl))
    //    {
    //        yield return web;
    //        AssetBundle remoteAssetBundle = web.assetBundle;
    //        if (remoteAssetBundle == null)
    //        {
    //            Debug.LogError("Failed to download AssetBundle!");
    //            yield break;
    //        }
    //        Instantiate(remoteAssetBundle.LoadAsset(assetName));
    //        remoteAssetBundle.Unload(false);
    //    }
    //}
}

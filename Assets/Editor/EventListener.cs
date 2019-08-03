using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class EventListener:UnityEditor.AssetModificationProcessor
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod() {
        //全局监听Project视图下的资源是否发生变化(添加，删除和移动)
        EditorApplication.projectWindowChanged = delegate () {
            Debug.Log("change");
        };
    }
    //监听 “双击鼠标左键，打开资源”
    public static bool IsOpenForEdit(string assetPath,out string message) {
        message = null;
        Debug.LogFormat("assetPath : {0}", assetPath);
        return true;
    }
    //监听“资源即将被创建”事件
    public static void OnWillCreateAsset(string path) {
        Debug.LogFormat("path : {0}",path);
    }
    //监听“资源即将被保存”事件
    public static string[] OnWillSaveAssets(string[] paths) {
        if (paths!=null)
        {
            Debug.LogFormat("path : {0}",string.Join(",",paths));
        }
        return paths;
    }
    //监听“资源即将被移动”事件
    public static AssetMoveResult OnWillMoveAsset(string oldPath ,string newPath) {
        Debug.LogFormat("from : {0} to : {1}",oldPath,newPath);
        //AssetMoveResult.DidMove 表示该资源可以移动
        return AssetMoveResult.DidMove;
    }
    public static AssetDeleteResult OnWillDeleteAsset(string assetPath) {
        Debug.LogFormat("delete : {0}",assetPath);
        //AssetDeleteResult.DidDelete 表示该资源可以被删除
        return AssetDeleteResult.DidDelete;
    }
}

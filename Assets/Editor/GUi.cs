using UnityEditor;
using UnityEngine;

public class GUi
{
   [InitializeOnLoadMethod]
   static void InitializeOnLoadMethod(){
       EditorApplication.projectWindowItemOnGUI=delegate(string guid,Rect selectionRect){
           if (Selection.activeObject && guid==AssetDatabase.AssetPathToGUID(
               AssetDatabase.GetAssetPath(Selection.activeObject)
           ))
           {
               float width=50f;
               selectionRect.x=(selectionRect.width-width);
               selectionRect.y+=2f;
               selectionRect.width=width;
               GUI.color=Color.red;
               if(GUI.Button(selectionRect,"click")){
                   Debug.LogFormat("click:{0}",Selection.activeObject.name);
               }
               GUI.color=Color.white;
           }
       };
   }
}

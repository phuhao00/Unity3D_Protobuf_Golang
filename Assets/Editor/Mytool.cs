using UnityEditor;
using UnityEngine;
public class Mytool
{
    [MenuItem("Assets/MyCreate/Cube",false,1)]
    static void CreateCube(){
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}

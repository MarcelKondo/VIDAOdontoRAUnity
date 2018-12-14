using UnityEngine;
using UnityEditor;

public static class DebugMenu
{
    [MenuItem("Debug/Print Global Position")]
    public static void PrintGlobalPosition()
    {
        if (Selection.activeGameObject != null)
        {
            Debug.Log(Selection.activeGameObject.name + " is at " + Selection.activeGameObject.transform.position);
        }
    }
    [MenuItem("Debug/Print Global Rotation")]
    public static void PrintGlobalRotation()
    {
        if (Selection.activeGameObject != null)
        {
            Debug.Log(Selection.activeGameObject.name + " has rotation " + Selection.activeGameObject.transform.rotation);
        }
    }
}
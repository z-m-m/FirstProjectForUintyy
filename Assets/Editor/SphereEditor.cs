using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Sphere))]
public class SphereEditor : Editor
{
    public override void OnInspectorGUI()
    {
        
        Sphere sphere =(Sphere) target;
        GUILayout.Label("调整模型大小");
        sphere.baseSize = EditorGUILayout.Slider("Size",sphere.baseSize, .1f, 3);
        sphere.transform.localScale = Vector3.one * sphere.baseSize;
    }
}

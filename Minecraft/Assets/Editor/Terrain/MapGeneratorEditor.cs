using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(MapGenerator)), CanEditMultipleObjects]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator) target;

        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }

        if (GUILayout.Button("Generate"))
        {
            mapGen.ChangeSeed();
            mapGen.GenerateMap();
        }
    }
}

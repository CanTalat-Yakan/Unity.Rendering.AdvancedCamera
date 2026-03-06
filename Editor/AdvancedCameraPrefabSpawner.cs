#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace UnityEssentials
{
    public class AdvancedCameraPrefabSpawner
    {
        [MenuItem("GameObject/Essentials/Advanced Camera", false, priority = 121)]
        private static void InstantiateAdvancedSpotLight(MenuCommand menuCommand)
        {
            var prefab = AssetResolverEditor.InstantiatePrefab("UnityEssentials_Prefab_AdvancedCamera", "Advanced Camera");
            if (prefab != null)
            {
                var camera = prefab.GetComponent<Camera>();
            }

            GameObjectUtility.SetParentAndAlign(prefab, menuCommand.context as GameObject);
            Undo.RegisterCreatedObjectUndo(prefab, "Create Advanced Camera");
            Selection.activeObject = prefab;
        }
    }
}
#endif
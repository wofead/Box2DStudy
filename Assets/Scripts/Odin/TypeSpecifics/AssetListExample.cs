using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class AssetListExample : MonoBehaviour
{
    [AssetList]
    [PreviewField(70, ObjectFieldAlignment.Center)]
    public Texture2D SingleObject;

    [AssetList(Path = "Plugins/Sirenix/")]
    public UnityEngine.Object Object;

    [AssetList(Path = "Plugins/Sirenix/")]
    public List<ScriptableObject> AssetList;

    [AssetList(AutoPopulate = true)]//自动填充符合规则的资源，false只显示不填充
    public List<MeshRenderer> AutoPopulatedWhenInspected;

    [AssetList(LayerNames = "MyLayerName")]
    public GameObject[] AllprefabsWithLayerName;

    [AssetList(AssetNamePrefix = "Pre_")]
    [FoldoutGroup("过滤后的AssetLists")]
    public List<GameObject> PrefabsStartWithPrefix;

    [AssetList(Tags = "Essential,EditorOnly", Path = "/TutorialAsset")]
    public List<GameObject> GameObjectsWithTag;

    [AssetList(CustomFilterMethod = "HasRigidbodyComponent")]
    public List<GameObject> MyRigidbodyPrefabs;

    private bool HasRigidbodyComponent(GameObject obj)
    {
        return obj.GetComponent<Rigidbody>() != null;
    }
}

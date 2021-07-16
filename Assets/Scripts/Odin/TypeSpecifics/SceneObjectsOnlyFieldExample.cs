using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectsOnlyFieldExample : MonoBehaviour
{
    [Title("Asset Only")]
    [AssetsOnly]
    public List<GameObject> onlyPrefabs;

    [AssetsOnly]
    public GameObject SomePrefab;

    [AssetsOnly]
    public Material MaterialAsset;

    [AssetsOnly]
    public MeshRenderer SomeMeshRendererOnPrefab;

    [Title("Scene Objects only")]
    [SceneObjectsOnly]
    public List<GameObject> OnlySceneObjects;

    [SceneObjectsOnly]
    public GameObject SomeSceneObject;

    [SceneObjectsOnly]
    public MeshRenderer SomeMeshRenderer;

    //[]


}


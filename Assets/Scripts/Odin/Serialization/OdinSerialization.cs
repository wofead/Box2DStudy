using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdinSerialization : SerializedMonoBehaviour
{
    //Odin序列化，因为Unity不支持字典的序列化
    public Dictionary<string, string> firstDictionary = new Dictionary<string, string>();

    // MyClassByUnity 因为标记为 Serializable ,所以使用Unity 自带的序列化，而非Odin 序列化
    public MyClassByUnity myUnityReference = new MyClassByUnity();

    //强制使用 Odin 序列化，而不使用Unity的序列化
    [NonSerialized, OdinSerialize]
    public MyClassByOdin myOdinReference = new MyClassByOdin();

    private void Start()
    {
        Debug.Log(firstDictionary.Count);
        Debug.Log(myUnityReference.secondDictionary_Unity.Count);
        Debug.Log(myOdinReference.secondDictionary_Odin.Count);
    }
}

[Serializable]
public class MyClassByUnity
{
    // 虽然标记为 OdinSerialize 特性, 但是依然不会被序列化
    [OdinSerialize]
    public Dictionary<string, string> secondDictionary_Unity = new Dictionary<string, string>();
}

[Serializable]
public class MyClassByOdin
{
    [OdinSerialize]
    [NonSerialized]
    public Dictionary<string, string> secondDictionary_Odin = new Dictionary<string, string>();
}
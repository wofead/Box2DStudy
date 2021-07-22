using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializationDebuggerTwo : SerializedMonoBehaviour
{
    public string UnityString = "UnityJow";

    [OdinSerialize]
    public string OdinAndUnityString = "OdinAndUnityString";

    [OdinSerialize]
    [NonSerialized]
    public string OdinString = "OdinJow";

    public List<string> OdinList = new List<string>();

    [SerializeField]
    public TempUnitySerializationData tempUnitySerializationData = new TempUnitySerializationData();

    public TempOdinSerializationData tempOdinSerializationData = new TempOdinSerializationData();

    public Dictionary<string,string> keyValuePairs = new Dictionary<string, string>();


    [Serializable]
    public class TempUnitySerializationData
    {
        public string UnityString = "Jow";

    }

    public class TempOdinSerializationData
    {
        public string UnityString = "Jow";
    }
}

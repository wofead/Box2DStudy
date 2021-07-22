using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializationDebuggerOne : MonoBehaviour
{
    public string UnityString = "UnityJow";
    public List<string> UnityStringList = new List<string>();

    [NonSerialized]
    [OdinSerialize]
    public string OdinStringInvalid = "Error Serialization";

    public TempUnitySerializationData tempUnitySerializationData = new TempUnitySerializationData();
    public TempOdinSerializationData tempOdinSerializationData = new TempOdinSerializationData();

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

using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RequiredExample : MonoBehaviour
{
    [Required]
    public GameObject MyGameObject;

    [Required("自定义错误消息"), PropertySpace]
    public Rigidbody MyRigidbody;

    public string DynamicMessage = "Dynamic Message";
    [Required("$DynamicMessage"), PropertySpace]
    public GameObject GameObjectDynamicString;

    [Required("$ReturnStringFunction"), PropertySpace]
    public GameObject GameObjectDynamicFunc;

    public string ReturnStringFunction()
    {
        return "Jow";
    }

    [Required("$DynamicMessage", InfoMessageType.None), PropertySpace]
    public GameObject GameObject_None;
    [Required("$DynamicMessage", InfoMessageType.Info), PropertySpace]
    public GameObject GameObject_Info;
    [Required("$DynamicMessage", InfoMessageType.Warning), PropertySpace]
    public GameObject GameObject_Warning;
    [Required("$DynamicMessage", InfoMessageType.Error), PropertySpace]
    public GameObject GameObject_Error;
}

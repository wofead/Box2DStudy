using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OnInspectorDispose : MonoBehaviour
{
    [OnInspectorDispose("@UnityEngine.Debug.Log(\"Dispose event invoked!\")")]
    [ShowInInspector, InfoBox("当重新创建、销毁、置空时，都会执行对应的Dispose操作."), DisplayAsString]
    public BaseClass PolymorphicField;
    public abstract class BaseClass
    { public override string ToString() { return this.GetType().Name; } }
    public class A : BaseClass { }
    public class B : BaseClass { }
    public class C : BaseClass { }
}

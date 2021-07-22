using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector.Editor;

#if UNITY_EDITOR
using Sirenix.OdinInspector;
using UnityEditor;
using Sirenix.Utilities.Editor;
using Sirenix.Utilities;
#endif

#if UNITY_EDITOR
//Place the drawer script file in an Editor folder or wrap it in a #if UNITY_EDITOR conditon.
public class CustomStructDrawer : OdinValueDrawer<MyStruct>
{
    protected override void DrawPropertyLayout(GUIContent label)
    {
        //获取我们绘制类的值
        MyStruct value = this.ValueEntry.SmartValue;

        //获取要绘制的区域（rect）
        var rect = EditorGUILayout.GetControlRect();
        //在Odin中，标签是可选项，可以为空，所以我们必须考虑到这一点。
        if (label !=null)
        {
            rect = EditorGUI.PrefixLabel(rect, label);
        }

        //保存原始labelWidth的宽度，此label为struct中对应的X,Y
        var prev = EditorGUIUtility.labelWidth;

        //设定新的label宽度
        EditorGUIUtility.labelWidth = CustomDrawerExample.labelWidth;

        //根据slider对应的值进行赋值
        value.X = EditorGUI.Slider(rect.AlignLeft(rect.width * 0.5f), "X", value.X, 0, 1);
        value.Y = EditorGUI.Slider(rect.AlignRight(rect.width * 0.5f), "Y", value.Y, 0, 1);

        //恢复设定原始label宽度
        EditorGUIUtility.labelWidth = prev;

        //将新的Struct赋值给我们定义的MyStruct
        this.ValueEntry.SmartValue = value;
    }
}
#endif

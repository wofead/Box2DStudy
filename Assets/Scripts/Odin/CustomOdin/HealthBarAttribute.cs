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

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class HealthBarAttribute : Attribute
{
    public float MaxHealth { get; private set; }
    public HealthBarAttribute(float maxHealth)
    {
        this.MaxHealth = maxHealth;
    }
}

#if UNITY_EDITOR
//Place the drawer script file in an Editor folder or wrap it in a #if UNITY_EDITOR conditon.
public class HealthBarAttributeDrawer:OdinAttributeDrawer<HealthBarAttribute, float>
{
    protected override void DrawPropertyLayout(GUIContent label)
    {
        //让此lable传递下去，便于其他的特性 进行绘制
        this.CallNextDrawer(label);

        //找一个矩形来绘制健康条。你也可以使用GUILayout，但使用Rects使绘制健康栏变的更简单。
        Rect rect = EditorGUILayout.GetControlRect();

        //Draw the health bar.
        float width = Mathf.Clamp01(this.ValueEntry.SmartValue / this.Attribute.MaxHealth);
        SirenixEditorGUI.DrawSolidRect(rect, new Color(0f, 0.1f, 0.6f, 0.3f), false);
        SirenixEditorGUI.DrawSolidRect(rect.SetWidth(rect.width * width), Color.red, false);
        SirenixEditorGUI.DrawBorders(rect, 1);
    }
}
#endif

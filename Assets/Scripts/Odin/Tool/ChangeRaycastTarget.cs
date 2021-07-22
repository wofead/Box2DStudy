using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRaycastTarget : SerializedScriptableObject
{
    private bool selectRaycastComplete;
    private bool cancelRaycastComplete;

    [PreviewField(50)]
    [OnValueChanged("SelectRaycastListValueChangeCallBack")]
    [HorizontalGroup("Raycast")]
    [PropertySpace(10, 10)]
    [BoxGroup("Raycast/Left", false)]
    [LabelText("需要选中RayCast拖入进来")]
    public List<GameObject> SelectRaycastList = new List<GameObject>();

    public void SelectRaycastListValueChangeCallBack()
    {
        selectRaycastComplete = false;
    }

    [PreviewField(50)]
    [OnValueChanged("CancelRaycastListValueChangeCallBack")]
    [PropertySpace(10, 10)]
    [BoxGroup("Raycast/Right", false)]
    [LabelText("需要取消RayCast拖入进来")]
    public List<GameObject> CancelRaycastList = new List<GameObject>();

    public void CancelRaycastListValueChangeCallBack()
    {
        cancelRaycastComplete = false;
    }

    [HideIf("@selectRaycastComplete==true||SelectRaycastList.Count==0")]
    [BoxGroup("Raycast/Left")]
    [Button("勾选所有射线检测", ButtonSizes.Large, ButtonStyle.FoldoutButton)]
    public void SelectRaycast()
    {
        for (int i = 0; i < SelectRaycastList.Count; i++)
        {
            if (SelectRaycastList[i] != null)
            {
                continue;
            }
            Graphic[] graphics = SelectRaycastList[i].GetComponentsInChildren<Graphic>();
            for (int j = 0; j < graphics.Length; j++)
            {
                graphics[j].raycastTarget = true;
                EditorUtility.SetDirty(graphics[j]);
            }
            GameObject gameObject = SelectRaycastList[i];
            bool isPrefabInstance = PrefabUtility.IsPartOfPrefabInstance(gameObject);
            bool isPrefabAsset = PrefabUtility.IsPartOfPrefabAsset(gameObject);

            if (isPrefabInstance)
            {
                PrefabUtility.ApplyPrefabInstance(SelectRaycastList[i], InteractionMode.UserAction);
            }

            if (isPrefabAsset)
            {
                PrefabUtility.SavePrefabAsset(SelectRaycastList[i]);
            }
        }
        selectRaycastComplete = true;
        AssetDatabase.Refresh();
    }

    [HideIf("@cancelRaycastComplete==true||CancelRaycastList.Count==0")]
    [BoxGroup("Raycast/Right")]
    [Button("取消所有射线检测", ButtonSizes.Large, ButtonStyle.FoldoutButton)]
    public void CancelRaycast()
    {
        for (int i = 0; i < CancelRaycastList.Count; i++)
        {
            if (CancelRaycastList[i] == null)
            {
                continue;
            }
            Graphic[] graphicArray = CancelRaycastList[i].GetComponentsInChildren<Graphic>();
            for (int k = 0; k < graphicArray.Length; k++)
            {
                graphicArray[k].raycastTarget = false;
                EditorUtility.SetDirty(graphicArray[k]);
            }
            GameObject tempObject = CancelRaycastList[i];
            bool isPrefabInstance = PrefabUtility.IsPartOfPrefabInstance(tempObject);
            bool isPrefabAsset = PrefabUtility.IsPartOfPrefabAsset(tempObject);

            if (isPrefabAsset)
            {
                PrefabUtility.SavePrefabAsset(CancelRaycastList[i]);
            }
            if (isPrefabInstance)
            {
                PrefabUtility.ApplyPrefabInstance(CancelRaycastList[i], InteractionMode.UserAction);
            }
        }
        cancelRaycastComplete = true;
        AssetDatabase.Refresh();
    }
}

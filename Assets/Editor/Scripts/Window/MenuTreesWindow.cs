using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using System.Linq;

public class MenuTreesWindow : OdinMenuEditorWindow
{
    [MenuItem("Odin/MenuTree")]
    public static void OpenWindow()
    {
        GetWindow<MenuTreesWindow>().Show();
    }

    protected override OdinMenuTree BuildMenuTree()
    {
        var tree = new OdinMenuTree();
        tree.DefaultMenuStyle = OdinMenuStyle.TreeViewStyle;

        tree.Add("Ment Style", tree.DefaultMenuStyle);

        var allAssets = AssetDatabase.GetAllAssetPaths()
           .Where(x => x.StartsWith("Assets/"))
           .OrderBy(x => x);
        foreach (var path in allAssets)
        {
            tree.AddAssetAtPath(path.Substring("Assets/".Length), path);
        }

        tree.EnumerateTree().AddThumbnailIcons();

        return tree;
    }
}

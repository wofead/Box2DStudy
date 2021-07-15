using Sirenix.OdinInspector;
using UnityEngine;

public class FolderPathExample : MonoBehaviour
{
    [FolderPath]
    public string UnityFolderPath;

    [FolderPath(ParentFolder = "Assets/Local")]
    public string RelativeFolderPath;

    [FolderPath(AbsolutePath = true)]
    public string AbsoleteFolderPath;

    //[FilePath(Extensions = "cs, unity")]
    //public string Extensions;

    // 默认情况下，FolderPath提供了一个相对于Unity项目的路径。
    [FolderPath]
    public string UnityProjectPath;

    // 如果提供的路径无效，还可以将FilePath配置为显示错误信息。
    [FolderPath(RequireExistingPath = true)]
    public string ExistingPath;

    // 默认情况下，FilePath将强制使用前斜杠。还可以将其配置为使用反斜杠
    [PropertySpace(40, 40)]
    [FolderPath(UseBackslashes = true)]
    public string Backslashes;

    // FilePath还支持使用$符号的成员引用。
    [FolderPath(ParentFolder = "$DynamicParent")]
    [BoxGroup("Member referencing")]
    public string DynamicFilePath;

    [BoxGroup("Member referencing")]
    public string DynamicParent = "Assets/Plugin/Sirenix";


    // FilePath还支持列表和数组。
    [FolderPath(ParentFolder = "Assets/Prefabs/")]
    [BoxGroup("Lists")]
    public string[] ListOfFiles;
}

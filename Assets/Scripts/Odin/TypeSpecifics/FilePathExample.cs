using Sirenix.OdinInspector;
using UnityEngine;

public class FilePathExample : MonoBehaviour
{
    [FilePath]
    public string UnityPath;

    [FilePath(ParentFolder = "Assets/Local")]
    public string RelativePath;

    [FilePath(AbsolutePath = true)]
    public string AbsoletePath;

    [FilePath(Extensions = "cs, unity")]
    public string Extensions;

    // 默认情况下，FolderPath提供了一个相对于Unity项目的路径。
    [FilePath]
    public string UnityProjectPath;

    // 提供一个逗号分隔的允许扩展列表。点（.）是可选的。
    [FilePath(Extensions = "cs, lua")]
    [BoxGroup("Conditions")]
    public string ScriptFiles;

    // 如果提供的路径无效，还可以将FilePath配置为显示错误信息。
    [FilePath(RequireExistingPath = true)]
    public string ExistingPath;

    // 默认情况下，FilePath将强制使用前斜杠。还可以将其配置为使用反斜杠
    [PropertySpace(40, 40)]
    [FilePath(UseBackslashes = true)]
    public string Backslashes;

    // FilePath还支持使用$符号的成员引用。
    [FilePath(ParentFolder = "$DynamicParent", Extensions = "$DynamicExtensions")]
    [BoxGroup("Member referencing")]
    public string DynamicFilePath;

    [BoxGroup("Member referencing")]
    public string DynamicParent = "Assets/Plugin/Sirenix";

    [BoxGroup("Member referencing")]
    public string DynamicExtensions = "cs, unity, jpg";

    // FilePath还支持列表和数组。
    [FilePath(ParentFolder = "Assets/Prefabs/")]
    [BoxGroup("Lists")]
    public string[] ListOfFiles;
}

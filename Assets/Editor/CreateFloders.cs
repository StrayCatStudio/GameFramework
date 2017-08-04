using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

/// <summary>
/// 一键创建项目文件夹
/// </summary>
public class CreateFloders : MonoBehaviour
{
#if UNITY_EDITOR
    /// <summary>
    /// 创建项目文件夹
    /// </summary>
    [MenuItem("Tools/CreateFloders #&_b")]
    public static void ToCreateFloders()
    {
        string _path = Application.dataPath;
        Directory.CreateDirectory(Path.Combine(_path, "AssetBundles"));
        Directory.CreateDirectory(Path.Combine(_path, "Editor"));
        Directory.CreateDirectory(Path.Combine(_path, "Plugins"));
        Directory.CreateDirectory(Path.Combine(_path, "Prefabs"));
        Directory.CreateDirectory(Path.Combine(_path, "Resources"));
        Directory.CreateDirectory(Path.Combine(_path, "Scenes"));
        Directory.CreateDirectory(Path.Combine(_path, "Scripts"));
        Directory.CreateDirectory(Path.Combine(_path, "StreamingAssets"));

        _path = Path.Combine(Application.dataPath, "ToBeAssetBundle");
        Directory.CreateDirectory(Path.Combine(_path, "Atlas"));
        Directory.CreateDirectory(Path.Combine(_path, "Audios"));
        Directory.CreateDirectory(Path.Combine(_path, "GUI"));
        Directory.CreateDirectory(Path.Combine(_path, "Materials"));
        Directory.CreateDirectory(Path.Combine(_path, "Models"));
        Directory.CreateDirectory(Path.Combine(_path, "Others"));
        Directory.CreateDirectory(Path.Combine(_path, "Shader"));
        Directory.CreateDirectory(Path.Combine(_path, "Textures"));
        Directory.CreateDirectory(Path.Combine(_path, "Xmls"));

        AssetDatabase.Refresh();

        Debug.Log("项目文件夹创建完成!");
    }
#endif
}

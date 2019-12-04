using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;


public class Copy
{
    [MenuItem("Assets/Copy")]
    static void AssetCopy()
    {
        
        // AnimationClipを持つFBXのパス
        string fbxPath = "Assets/AssetFolder/Crusader knight/animation/crusader@atack3.fbx";
        // AnimationClipのファイル名
        string clipName = "attack3";
        // AnimationClipの出力先
        string exportPath = "Assets/Pantheon/Animation";

        string tempExportedClip = "Assets/Pantheon/Animation";

        // AnimationClipの取得
        var animations = AssetDatabase.LoadAllAssetsAtPath(fbxPath);
        var originalClip = System.Array.Find<Object>(animations, item =>
              item is AnimationClip && item.name == clipName
        );

        // AnimationClipをコピーして出力(ユニークなuuid)
        var copyClip = Object.Instantiate(originalClip);
        AssetDatabase.CreateAsset(copyClip, tempExportedClip);

        // AnimationClipのコピー（固定化したuuid）
        File.Copy(tempExportedClip, exportPath, true);
        File.Delete(tempExportedClip);

        // AssetDatabaseリフレッシュ
        AssetDatabase.Refresh();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

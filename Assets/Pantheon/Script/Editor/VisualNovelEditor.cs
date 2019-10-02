using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VisualNovelInfo))]
public class VisualNovelEditor : Editor
{
    /// <summary>
	/// コマンド番号表示の幅
	/// </summary>
	public const float CommandIndexWidth = 30.0f;
    /// <summary>
    /// コマンド表示の幅
    /// </summary>
    public const float CommandPropertyWidth = 150.0f;
    /// <summary>
    /// コマンド引数表示の幅
    /// </summary>
    public const float CommandParameterPaddingWidth = 40.0f;

    /// <summary>
	/// コマンド名
	/// </summary>
	private string[] commands = null;
    /// <summary>
    /// グループ名
    /// </summary>
    public string[] groups = null;

    private void Setup()
    {

    }
}

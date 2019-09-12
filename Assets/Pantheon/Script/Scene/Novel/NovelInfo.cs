using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(
   fileName = "NovelInfo",
   menuName = "Pantheon/NovelInfo",
   order = 8)
]

public class NovelInfo : ScriptableObject
{
    public List<NovelModel> NovelInfoList = new List<NovelModel>();

}
[System.Serializable]

public class NovelModel
{
    /// <summary>
	/// ノベルデータの説明(注釈)
	/// </summary>
	[SerializeField]
    [Tooltip("ノベルデータの説明等(自由欄)")]
    public string comment;
    /// <summary>
	/// ノベルコマンド
	/// </summary>
	[SerializeField]
    public List<Command> commands = new List<Command>();

    /// <summary>
	/// コマンドデータ
	/// </summary>
	[System.Serializable]
    public class Command
    {
        /// <summary>
        /// コマンドID
        /// </summary>
        [SerializeField]
        public int id;

        /// <summary>
        /// コマンド引数
        /// </summary>
        [SerializeField]
        public string[] parameters;
    }
}



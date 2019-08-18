using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "EnemyStatusData",
   menuName = "ScriptableObject/EnemyStatusData", 
   order =0 )
]
public class EnemyStatusData : ScriptableObject
{


    //ListステータスのList
    public List<EnemyStatus> EnemyStatusList = new List<EnemyStatus>();

}

//System.Serializableを設定しないと、データを保持できない(シリアライズできない)ので注意
[System.Serializable]
public class EnemyStatus
{

    //設定したいデータの変数
    public string Name = "なまえ";
    public int HP = 100, SP = 50, Atk = 5, Def = 15, Spd = 99, Exp = 58;
    public bool IsBoss = false;
    /*簡略化のために全てpublicにしてますが、Scriptableobjectは基本的に変更しないデータを扱うので、
 以下のようにprivateな変数にSerializeFieldを付けて、getterとsetterを別途用意する方が安全です。
 setterは後述する「プログラムから作成」の時に使います。

 [SerializeField]
 private bool _isBoss = false;
 public  bool  IsBoss {
   get { return _isBoss; }
   #if UNITY_EDITOR
   set { _isBoss = value; }
   #endif
   [MenuItem("Tools/MyTool/Do It in C#")]
   static void DoIt()
   {
      // EditorUtility.DisplayDialog("MyTool", "Do It in C# !", "OK", "");
   }
    */
}
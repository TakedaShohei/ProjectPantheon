using UnityEngine;
using UnityEditor;
using UnityEngine.Audio;

[CreateAssetMenu(
   fileName = "MusicInfo",
   menuName = "Pantheon/MuiskInfo",
   order = 12)
]
public class MusicInfo : ScriptableObject
{
    [SerializeField]
    private static float bgm_volume_;
    public  static float BgmVolume
    {
        get { return bgm_volume_; }
        protected set { bgm_volume_ = value; }
    }
    public static float Volume;
   

}
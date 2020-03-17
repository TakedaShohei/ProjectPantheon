using UnityEngine;
using System.Collections;

public class TitleBGM :MonoBehaviour
{

   
    

    // Use this for initialization
    void Start()
    {
      
       SoundManager.Instance.PlayBgmByName("BattleBGM");
        
    }


}

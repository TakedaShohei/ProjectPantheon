using UnityEngine;
using System.Collections;

public class MypageBGM : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        SoundManager.Instance.PlayBgmByName("MyHomeBGM");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

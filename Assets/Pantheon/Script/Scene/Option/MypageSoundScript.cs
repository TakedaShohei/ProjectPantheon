using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MypageSoundScript : MonoBehaviour{

    public bool DontDestroyEnabled = true;

    private void Start()
    {
        if (DontDestroyEnabled)
        {
            DontDestroyOnLoad(this);
        }
        if (SceneManager.GetActiveScene().name == "SelectStage")
        {
            Destroy(this);
        }
    }


}
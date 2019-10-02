using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FacilitatePage : MonoBehaviour
{
    [SerializeField]
    private Vector2 screenSize;
    public Vector2 ScreenSize
    {
        get { return screenSize; }
        protected set { screenSize = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // PCならウィンドウサイズ調整
        if (Application.platform == RuntimePlatform.WindowsPlayer ||
            Application.platform == RuntimePlatform.LinuxPlayer ||
            Application.platform == RuntimePlatform.OSXPlayer)
        {
            Screen.SetResolution((int)screenSize.x, (int)screenSize.y, true);
        }

    }
  
}

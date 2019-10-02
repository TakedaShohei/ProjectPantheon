using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
   

    public void LoadSetting()
    {
        GameObject.Find("Canvas").transform.Find("MenuPanel").gameObject.SetActive(true);
    }

    public void Cancel()
    {
        GameObject.Find("MenuPanel").SetActive(false);
    }

   

}
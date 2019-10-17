using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{

    public string panel_;
    public string main_; 
    public void LoadSetting()
    {
        GameObject.Find("UIIcon").transform.Find("MenuPanel").gameObject.SetActive(true);
    }

    public void Cancel()
    {
        GameObject.Find("MenuPanel").SetActive(false);
    }

    public void LoadPanel()
    {
        GameObject.Find(main_).transform.Find(panel_).gameObject.SetActive(true);
    }

    public void Close()
    {
        GameObject.Find(panel_).SetActive(false);
    }
   

}
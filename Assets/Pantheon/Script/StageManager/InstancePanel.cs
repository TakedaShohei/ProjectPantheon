using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstancePanel : MonoBehaviour
{
    bool check = true;//条件分岐用のbool変数
    public GameObject gameObject; //オリジナルのオブジェクト
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnInstance_Panel()
    {
        gameObject.SetActive(false);

    }

   public void Destroy_Panel()
    {
        Destroy(gameObject);    
    }

   
   

    public void Onclick()
    {
        Debug.Log("1");
        if (!check)
        {
            gameObject.SetActive(false);
            Debug.Log("2");
            check = true;
        }
        else if (check)
        {
            gameObject.SetActive(true);
            Debug.Log("3");
            check = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstancePanel : MonoBehaviour
{
   
    public GameObject location_;
    private GameObject object_;
    // Start is called before the first frame update
    void Start()
    {
         

}

    // Update is called once per frame
    void Update()
    {
        
    }
  

    public void CreateAndDestroy(GameObject prefab)
    {
        // 生成
        if (object_ == null)
        {
            object_ =(GameObject) Instantiate(prefab,new Vector3(200.0f,195.5f,0.0f),Quaternion.identity);
            object_.transform.parent = location_.transform;
        }

        // 破壊
        else
        {
            Destroy(object_);
        }
    }
}

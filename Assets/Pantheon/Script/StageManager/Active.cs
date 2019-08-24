using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Active : MonoBehaviour
{
    public GameObject SelectButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeButton(int value)
    {
        switch (value)
        {
            case 0:
                SelectButton.SetActive(true);
                break;
            case 1:
                SelectButton.SetActive(true);
                break;
            case 2:
                SelectButton.SetActive(true);
                break;
            default:
                break;
        }
    }
}

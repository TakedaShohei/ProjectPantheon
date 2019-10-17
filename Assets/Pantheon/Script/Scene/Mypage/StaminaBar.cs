using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public float speed = 5.0f;
    public Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class DamageText : MonoBehaviour
{
    int damage_value_ = 0;

    [SerializeField] TextMeshProUGUI damage_text_object_ = null;

    public void Setup(int damage_value)
    {
        damage_value_ = damage_value;

        damage_text_object_.text=damage_value_.ToString();

        if (this.gameObject == true)
        {
            //Invoke("UpdateDamageText", 2.0f);
        }
    }

    public void UpdateDamageText()
    {
        this.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
   
   
}

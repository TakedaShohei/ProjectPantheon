using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPGauge : MonoBehaviour
{
    int max_hp_ = 0;
    int current_hp_ = 0;


    [SerializeField]Slider slider_ = null;

    public void SetUp(int max_hp)
    {
        max_hp_ = max_hp;
        current_hp_ = max_hp_;
        slider_.maxValue = max_hp;

        UpdateSlider();
    }

    public void UpdateHp(int add_hp)
    {
        current_hp_ += add_hp;
        if (current_hp_ > max_hp_) current_hp_ = max_hp_;
        if (current_hp_ < 0) current_hp_ = 0;
        
        UpdateSlider();
    }

    void UpdateSlider()
    {
        slider_.value = current_hp_;
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

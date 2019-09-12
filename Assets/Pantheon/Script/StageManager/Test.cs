using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    private Image backgorund_image_;
    private Sprite chara;
    // Use this for initialization
    void Start()
    {
        chara = Resources.Load<Sprite>("Character/kohaku_angry");
        backgorund_image_ = this.GetComponent<Image>();
        backgorund_image_.sprite = chara;
    }
}

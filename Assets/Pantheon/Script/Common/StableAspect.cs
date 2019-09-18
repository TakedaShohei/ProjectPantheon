using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableAspect : MonoBehaviour
{
    public Camera cam;
    public float width = 454f;
    public float height = 252f;
    // 画像のPixel Per Unit
    private float pixelPerUnit = 200f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        float aspect = (float)Screen.height / (float)Screen.width; //表示画面のアスペクト比
        float bgAcpect = height / width; //理想とするアスペクト比

        // カメラコンポーネントを取得します
        cam = GetComponent<Camera>();

        // カメラのorthographicSizeを設定
        cam.orthographicSize = (height / 2f / pixelPerUnit);

        if (bgAcpect > aspect)
        {
            //画面が横に広いとき
            // 倍率
            float bgScale = height / Screen.height;
            // viewport rectの幅
            float camWidth = width / (Screen.width * bgScale);
            // viewportRectを設定
            cam.rect = new Rect((1f - camWidth) / 2f, 0f, camWidth, 1f);

        }
        else
        {
            //画面が縦に長い
            //想定しているアスペクト比とどれだけ差があるかを出す
            float bgScale = aspect / bgAcpect;

            // カメラのorthographicSizeを縦の長さに合わせて設定しなおす
            cam.orthographicSize *= bgScale;

            // viewportRectを設定
            cam.rect = new Rect(0f, 0f, 1f, 1f);
        }
    }
}
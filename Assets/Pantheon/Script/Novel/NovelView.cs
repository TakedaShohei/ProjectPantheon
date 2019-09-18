using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class NovelView : MonoBehaviour
{
    [SerializeField]
    private Transform canvases_;
    public Transform Canvases
    {
        get { return canvases_; }
        protected set { canvases_ = value; }
    }

    [SerializeField]
    private Canvas stageCanvas_;
    public Canvas StageCanvas
    {
        get { return stageCanvas_; }
        protected set { stageCanvas_ = value; }
    }

    [SerializeField]
    private CanvasScaler stageScanvasScaler_;
    public CanvasScaler StageScanvasScaler
    {
        get { return stageScanvasScaler_; }
        protected set { stageScanvasScaler_ = value; }
    }

    [SerializeField]
    private RectTransform stage;
    public RectTransform Stage
    {
        get { return stage; }
        protected set { stage = value; }
    }

    [SerializeField]
    private List<GameObject> stageObjects;
    public List<GameObject> StageObjects
    {
        get { return stageObjects; }
        protected set { stageObjects = value; }
    }


    [SerializeField]
    private Canvas novelCanvas;
    public Canvas NovelCanvas
    {
        get { return novelCanvas; }
        protected set { novelCanvas = value; }
    }

    [SerializeField]
    private Image textWindowImage;
    public Image TextWindowImage
    {
        get { return textWindowImage; }
        protected set { TextWindowImage = value; }
    }

    [SerializeField]
    private TMPro.TextMeshProUGUI text;
    public TMPro.TextMeshProUGUI Text
    {
        get { return text; }
        protected set { text = value; }
    }

    [SerializeField]
    private Image nextIconImage;
    public Image NextIconImage { get { return nextIconImage; } }
    [SerializeField]
    private Animation nextIconAnimation;
    public Animation NextIconAnimation { get { return nextIconAnimation; } }
    [SerializeField]
    private Image nameTextWindowImage;
    public Image NameTextWindowImage { get { return nameTextWindowImage; } }
    [SerializeField]
    private TMPro.TextMeshProUGUI nameText;
    public TMPro.TextMeshProUGUI NameText { get { return nameText; } }

    [SerializeField]
    private Canvas uiCanvas;
    public Canvas UICanvas { get { return uiCanvas; } }
    [SerializeField]
    private Button settingButton;
    public Button SettingButton { get { return settingButton; } }
    [SerializeField]
    private Image settingButtonImage;
    public Image SettingButtonImage { get { return settingButtonImage; } }
    [SerializeField]
    private GameObject touchScreenObject;
    public GameObject TouchScreenObject { get { return touchScreenObject; } }
}

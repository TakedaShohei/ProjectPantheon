using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleScene : MonoBehaviour, ISceneWasLoaded
{
    [SerializeField] Transform enemy_trans_ = null;
    [SerializeField] Transform enemy_effect_trans_ = null;
    [SerializeField] Transform player_trans_ = null;
    [SerializeField] Transform player_effect_trans_ = null;
    [SerializeField] Transform player_ui_trans_ = null;
    [SerializeField] Transform enemy_ui_trans_ = null;
    [SerializeField] Transform battle_ui_ = null;
    [SerializeField] BattleInfo model_ = null;
    [SerializeField] PlayerInfo player_info_ = null;
    [SerializeField] PlayerCommandInfo player_command_info_ = null;
    [SerializeField] PlayerCommoandUI player_commaond_ui_ = null;
    [SerializeField] Image Background_UI_ = null;
    [SerializeField] GameObject Background_Object_ = null;
    [SerializeField] ParticleSystem player_particle_ = null;
    [SerializeField] AIContoller ai_controller = null;


    List<User> user_list_ = new List<User>();
    List<Enemy> enemy_list_ = new List<Enemy>();

    BattleMain battle_main_ = null;
    
    private Sprite sprite;




    public void OnSceneWasLoaded(object[] arguments)
    {
        StageModel stage_model = arguments[0] as StageModel;
        model_ = stage_model.BattleInfo;
        Debug.Log("OnSceneWasLoaded." + model_.name);
    }

    void Setup()
    {
        // バトルシーン単体起動の時用
        model_ = Resources.Load("ScriptableObject/Battle/BattleInfo1_1" ) as BattleInfo;
        player_info_ = Resources.Load("ScriptableObject/Battle/PlayerInfo") as PlayerInfo;
        player_command_info_ = Resources.Load("ScriptableObject/Battle/PlayerCommandInfo") as PlayerCommandInfo;

        

        // 背景をロードして配置
        CreateBackground();
        //行動ボタンを作成。
       // CreatePlayerCommand();

        // 敵キャラクターのロードして配置
        CreateEnemy();

        // 味方キャラクターのロードして配置
        CreatePlayer();
        
        // バトルメイン作成
        battle_main_ = new BattleMain();
        battle_main_.Setup(user_list_, enemy_list_);

        // AI
        ai_controller.Setup(battle_main_);

        // UIの初期化
        player_commaond_ui_.Setup(battle_main_);

        // 準備が整ったらバトルスタート
        battle_main_.CurrentBattleState = BattleMain.BattleState.InBattle;
    }

    void CreateBackground()
    {

        // 一旦はバトルはリストの0番目のみ
        // GameObject bg = Resources.Load(model_.BattleInfoList[0].background_prefab_) as GameObject;
        //    Instantiate(bg, new Vector3(0, 0, 0), Quaternion.identity);
        //Sprite sprite = Resources.Load("Background/FantasyWorld")as Sprite;
        sprite = Resources.Load<Sprite>(model_.BattleInfoList[0].background_prefab_);
        Background_UI_ = Background_Object_.GetComponent<Image>();
        Background_UI_.sprite = sprite;

    }

    void CreateEnemy()
    {
        BattleInfo.BattleModel battle_model = model_.BattleInfoList[0];
        foreach(EnemyModel enemy in battle_model.enemy_list)
        {
            GameObject enemy_prefab = (GameObject)Resources.Load(enemy.ModelPrefab);
            GameObject enemy_go = Instantiate(enemy_prefab, enemy_trans_);

            //GameObject enemy_hpbar_prefab = Resources.Load("Prefab/Battle/UI/PlayerHpBar")as GameObject;
            GameObject enemy_hpbar_prefab = player_command_info_.PlayerHpBar;
            HPGauge hp_gauge = Instantiate(enemy_hpbar_prefab,enemy_ui_trans_).GetComponent<HPGauge>();
            hp_gauge.SetUp(enemy.Hp);

            enemy_effect_trans_ = enemy_go.transform.Find("RightHandEffector");

            //ここをリスト化した意味は？　リスト化したのはデータの更新のため？
            Enemy enemy_data = enemy_go.GetComponent<Enemy>();
            enemy_data.GameObjectBattler = enemy_go;
            enemy_data.Hpgauge = hp_gauge;
            enemy_data.MoveTransform = enemy_trans_;
            enemy_data.EffectTransform = enemy_effect_trans_;
            enemy_data.Setup(enemy);
            enemy_list_.Add(enemy_data);
        }
    }

    void CreatePlayer()
    {
        // 所持キャラ一覧[キャラinfoのidの配列] //
        // パーティ[キャラinfoのidの配列]

        List<PlayerInfo> user_chara_list = new List<PlayerInfo>();
        BattleInfo.BattleModel battle_model = model_.BattleInfoList[0];
        foreach (PlayerModel player in player_info_.PlayerInfoList)
        {
            //Summon Playerprefab from PlayerInfo 
            GameObject player_prefab = (GameObject)Resources.Load(player.ModelPrefab);
            GameObject player_go = Instantiate(player_prefab, player_trans_);
            

            //Connect HpGauge and PlayerHp
            GameObject player_hpbar_prefab = player_command_info_.PlayerHpBar;
            HPGauge hp_gauge = Instantiate(player_hpbar_prefab, player_ui_trans_).GetComponent<HPGauge>();
            hp_gauge.SetUp(player.Hp);

            //Instance effect_prehab
            //Heavyknight(Clone)/Crusader_Ctrl_Reference/Crusader_Ctrl_RightHandThumbEffector

            player_effect_trans_ = player_go.transform.Find("RightHandEffector");


            GameObject effect_prehab = player.Effect;
            GameObject effect_go = Instantiate(effect_prehab, player_effect_trans_);
            player_particle_ = effect_go.GetComponent<ParticleSystem>();



            //Connect user with PlayerInfo
            User user_data = player_go.GetComponent<User>();
            user_data.GameObjectBattler = player_go;
            user_data.Hpgauge = hp_gauge;
            user_data.MoveTransform = player_trans_;
            user_data.EffectParticle = player_particle_;//New
            user_data.EffectTransform = player_effect_trans_;
            user_data.Setup(player);            
            user_list_.Add(user_data);


        }
    }

   
    void CreatePlayerCommand()
    {
        GameObject player_command_ui_ = player_command_info_.PlayerCommandUI;
        GameObject button = Instantiate(player_command_ui_, battle_ui_);
        button.transform.position = new Vector3(0, 0, 0);
    }

    // Use this for initialization
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        battle_main_.Update();
    }
}

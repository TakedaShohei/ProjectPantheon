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
    [SerializeField] Transform player_damage_ui_trans_ = null; 
    [SerializeField] Transform enemy_ui_trans_ = null;
    [SerializeField] BattleUI battle_ui_ = null;
    [SerializeField] Transform battle_ui_trans_ = null;
    [SerializeField] BattleInfo model_ = null;
    [SerializeField] PlayerInfo player_info_ = null;
    [SerializeField] StageInfo stage_info_ = null;
    [SerializeField] PlayerCommandInfo player_command_info_ = null;
    [SerializeField] PlayerCommoandUI player_commaond_ui_ = null;
    [SerializeField] Image Background_UI_ = null;
    [SerializeField] GameObject Background_Object_ = null;
    [SerializeField] Image chara_ui_ = null;
    [SerializeField] GameObject chara_image_ = null;
    [SerializeField] ParticleSystem player_particle_ = null;
    [SerializeField] AIContoller ai_controller = null;
    [SerializeField] GameObject chara_name_obj_ = null;
    [SerializeField] GameObject stage_plane_ = null;
  

    List<User> user_list_ = new List<User>();
    List<Enemy> enemy_list_ = new List<Enemy>();

    BattleMain battle_main_ = null;
    private Sprite sprite;
   




    public void OnSceneWasLoaded(object[] arguments)
    {
        StageModel stage_model = arguments[0] as StageModel;
        model_ = stage_model.BattleInfo;
        BattleData.SetStageModel(stage_model);
        Debug.Log("OnSceneWasLoaded." + model_.name);
    }

    void Setup()
    {
        // バトルシーン単体起動の時用
        if (model_ == null)
        {
            model_ = Resources.Load("ScriptableObject/Battle/BattleInfo1_1") as BattleInfo;
            player_info_ = Resources.Load("ScriptableObject/Battle/PlayerInfo") as PlayerInfo;
            player_command_info_ = Resources.Load("ScriptableObject/Battle/PlayerCommandInfo") as PlayerCommandInfo;
            stage_info_ = Resources.Load("ScriptableObject/Stage/StageInfo1") as StageInfo;
            BattleData.SetStageModel(stage_info_.StageInfoList[0]);
        }
            
        

        // 背景をロードして配置
        CreateBackground();
        //行動ボタンを作成。
        // CreatePlayerCommand();

        //ステージのmaterialを変更
        CreatePlane();

        // イメージ画像をロード
        CreateCharaImage();

        //キャラクター名前更新
        CreateCharaName();

        // 敵キャラクターのロードして配置
        CreateEnemy();

        // 味方キャラクターのロードして配置
        CreatePlayer();
        
        // バトルメイン作成
        battle_main_ = new BattleMain();
        battle_main_.Setup(user_list_, enemy_list_, battle_ui_);

        // AI
        ai_controller.Setup(battle_main_);

        // UIの初期化
        player_commaond_ui_.Setup(battle_main_);
       
             //スキルアクションの初期化
      // skill_aciton_.Setup(battle_main_);


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
    void CreatePlane()
    {
        Material stage_material_ = stage_info_.StageInfoList[0].Material;
        
        stage_plane_.GetComponent<Renderer>().material = stage_material_;
    }
    void CreateCharaImage()
    {
        foreach(PlayerModel player in player_info_.PlayerInfoList)
        {
            sprite = Resources.Load<Sprite>(player.PlayerImage);
            chara_ui_ = chara_image_.GetComponent<Image>();
            chara_ui_.sprite = sprite;
        }
       
    }
    void CreateCharaName()
    {
        foreach (PlayerModel player in player_info_.PlayerInfoList)
        {
            Text chara_name_text_ = chara_name_obj_.GetComponent<Text>();
          //  TextMesh chara_name_textmesh_ = chara_name_obj_.GetComponent<TextMesh>();
            chara_name_text_.text = player.Name;
           
        }
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

            GameObject enemy_damage_text_prehab = player_command_info_.PlayerDamageTextUi;
            DamageText damage_text = Instantiate(enemy_damage_text_prehab, enemy_ui_trans_).GetComponent<DamageText>();
            damage_text.gameObject.SetActive(false);
            enemy_effect_trans_ = enemy_go.transform.Find("RightHandEffector");

            //ここをリスト化した意味は？　リスト化したのはデータの更新のため？
            Enemy enemy_data = enemy_go.GetComponent<Enemy>();
            enemy_data.GameObjectBattler = enemy_go;
            enemy_data.Hpgauge = hp_gauge;
            enemy_data.MoveTransform = enemy_trans_;
            enemy_data.EffectTransform = enemy_effect_trans_;
            enemy_data.Setup(enemy);
            enemy_list_.Add(enemy_data);
            enemy_data.DamageText = damage_text;
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

            GameObject player_damage_text_prehab = player_command_info_.PlayerDamageTextUi;
            DamageText damage_text = Instantiate(player_damage_text_prehab, player_damage_ui_trans_).GetComponent<DamageText>();
            damage_text.gameObject.SetActive(false);
            //Instance effect_prehab
            //Heavyknight(Clone)/Crusader_Ctrl_Reference/Crusader_Ctrl_RightHandThumbEffector

            //player_effect_trans_ = player_go.transform.Find(player.EffectTransform);
            Transform  player_effect_trans = player_go.transform.Find("Crusader_Ctrl_Reference/Crusader_Ctrl_RightHandMiddleEffector");
            player_effect_trans_ = GameObject.Find(player.EffectTransform).transform;


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
            user_data.DamageText = damage_text;

        }
    }

   
    void CreatePlayerCommand()
    {
        GameObject player_command_ui_ = player_command_info_.PlayerCommandUI;
        GameObject button = Instantiate(player_command_ui_, battle_ui_trans_);
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
        if (battle_main_ == null) return;
        battle_main_.Update();
    }
}

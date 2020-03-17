using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VolumeManager : MonoBehaviour
{
    public MusicInfo music_info = null;
    public static float music_volume_ = 0;
    
    [SerializeField] Slider music_slider_ = null;
    [SerializeField] private AudioMixer audio_mixer_;
    //　GameSoundShot
    [SerializeField] private AudioMixerSnapshot gameSoundShot;
    //　OptionSoundShot

    
    private void Start()
    {
        music_slider_ = GetComponent<Slider>();
        float min_valume_ = -50f;
        float max_valume_ = 5f;
        
        //スライダーの最大値の設定
        //music_slider_.minValue = min_valume_;

        //music_slider_.maxValue = max_valume_;

        




    }

    public  void SetUp()
    {
        
    }

    
    public void SetMaster(float volume)
    {
        audio_mixer_.SetFloat("MasterVol", volume);
    }

    public void SetBGM()
    {

        SoundManager.Instance.BgmVolume = music_slider_.value;

        Debug.Log(music_volume_);
        
    }

    public static void UpdateMusic(float current_volume)
    {
        
    }

    void UpdateSlider()
    {
      //  music_slider_.value = ;

    }

    public void SetSE()
    {
        audio_mixer_.SetFloat("SEVol", music_volume_);
    }

    //使用するAudioSource取得
    //  source = GetComponent<AudioSource>();

    //最初のBGM再生
    //source.m = audioMixer;
    //source.Play();

    //シーンが切り替わった時に呼ばれるメソッドを登録



}

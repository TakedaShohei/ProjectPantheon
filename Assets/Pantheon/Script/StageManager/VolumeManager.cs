using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VolumeManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private AudioSource source;

    [SerializeField]
    private AudioClip bgm_title_;
    [SerializeField]
    private string SceneName;


    //　GameSoundShot
    [SerializeField]
    private AudioMixerSnapshot gameSoundShot;
    //　OptionSoundShot

    public bool DontDestroyEnabled = true;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        //使用するAudioSource取得
      //  source = GetComponent<AudioSource>();

        //最初のBGM再生
        //source.m = audioMixer;
        //source.Play();

        //シーンが切り替わった時に呼ばれるメソッドを登録

    }


    void Update()
    {

       




    }

    public void SetMaster(float volume)
    {
        audioMixer.SetFloat("MasterVol", volume);
    }

    public void SetBGM(float volume)
    {
        audioMixer.SetFloat("BGMVol", volume);
        Debug.Log(volume);
        
    }

    public void SetSE(float volume)
    {
        audioMixer.SetFloat("SEVol", volume);
    }




}

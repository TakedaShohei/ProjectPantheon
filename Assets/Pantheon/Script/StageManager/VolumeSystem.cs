using UnityEngine;
using System.Collections;

public class VolumeSystem : MonoBehaviour
{

    
    // Use this for initialization
    void Start()
    {
        VolumeManager volume_manager = GetComponent<VolumeManager>();
        volume_manager.SetBGM();

    }

    // Update is called once per frame
    void Update()
    {

    }
}

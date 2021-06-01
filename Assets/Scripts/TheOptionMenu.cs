using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TheOptionMenu : MonoBehaviour
{
    private AudioSource audiosrc;
    private float musicvolume = 1f;
    private void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audiosrc.volume = musicvolume;
    }
    public void SetVolume (float volume)
    {
        musicvolume = volume;
    }
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length>1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }

}

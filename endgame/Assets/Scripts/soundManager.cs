using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public AudioSource music_src;

    public AudioClip music_src_stage4;

    public AudioSource Player;
    public AudioSource Npc;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetVol(float volume)
    {
        music_src.volume = volume;
    }

    public void SeteffectVol(float volume)
    {
        Player.volume = volume;
        Npc.volume = volume;
    }

    public void set_player_npc()
    {
        Player = GameObject.Find("Player").GetComponent<AudioSource>();
        Npc = GameObject.Find("father").GetComponent<AudioSource>();
    }

}

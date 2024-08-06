using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Script_MineCoinButton : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clip;
    public Script_CoinManager coinManager;
    public Script_MoneyParticleController moneyParticleSystem;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(moneyParticleSystem);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void ButtonClick()
    {
        src.clip = clip;
        src.Play();
        coinManager.MineCoin();
        moneyParticleSystem.CreateParticle();
    }
}
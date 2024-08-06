using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_MoneyParticleController : MonoBehaviour
{
    
    public GameObject particle;
    public float particleLifetime = 2f;

    public void CreateParticle()
    {

        GameObject part = Instantiate(particle);
        Destroy(part, particleLifetime);
    }

    // Start is called before the first frame update
    //void Start()
    //{
        

    //}


    // Update is called once per frame
    //void Update()
    //{     
        
    //}
}

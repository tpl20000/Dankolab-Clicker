using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Script_MoneyParticleMovement : MonoBehaviour
{

    float Xvelocity;
    float Yvelocity;
    float gravAcceleration;
    float Xrotation;
    float Yrotation;
    Vector3 moveVector;
    Vector3 rotateVector;
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        Xvelocity = Random.Range(-0.002f, 0.002f);
        Yvelocity = 0.03f;
        gravAcceleration = -0.002f;
        Xrotation = Random.Range(-1f, 1f);
        Yrotation = Random.Range(-1f, 1f);
        moveVector = Vector3.zero;
        rotateVector = Vector3.zero;

        particle.transform.rotation = Random.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x += Xvelocity;
        Yvelocity += gravAcceleration;
        moveVector.y += Yvelocity;

        rotateVector.x += Xrotation;
        rotateVector.y += Yrotation;

        transform.Translate(moveVector);
        particle.transform.Rotate(rotateVector);
    }
}

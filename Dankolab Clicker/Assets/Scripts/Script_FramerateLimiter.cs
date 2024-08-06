using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_FramerateLimiter : MonoBehaviour
{

    public int targetFramerate = 60;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFramerate;
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.targetFrameRate != targetFramerate)
        {
            Application.targetFrameRate = targetFramerate;
        }
    }
}

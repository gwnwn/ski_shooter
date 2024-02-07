using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour
{
    public float Speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControl.hp == 0)
        {
            return;
        }

        foreach (Transform tran in transform)
        {
            Vector3 pos = tran.position;
            pos.x -= Speed * Time.deltaTime;
            if(pos.x < -30.0f)
            {
                pos.x += 30.0f * 2;
            }
            tran.position = pos;
        }
    }
}

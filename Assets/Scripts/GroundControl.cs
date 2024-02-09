using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundControl : MonoBehaviour
{
    public float Speed = 5f;
    public GameObject[] GroundPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControl.hp == 0)
        {
            PlayerControl.hp = 1;
            Attack.bulletNum = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        foreach (Transform tran in transform)
        {
            Vector3 pos = tran.position;
            pos.x -= Speed * Time.deltaTime;
            if (pos.x < -36.0f)
            {
                //Create new ground
                Transform newTrans = Instantiate(GroundPrefabs[Random.Range(0, GroundPrefabs.Length)], transform).transform;
                //get pos of new ground
                Vector2 newPos = newTrans.position;
                //set pos of new ground

                newPos.x = pos.x + 30.0f * 2;
                newTrans.position = newPos;

                //destroy old ground
                Destroy(tran.gameObject);
            }
            tran.position = pos;
        }
    }
}

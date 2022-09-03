using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");

        for(int i = 0; i < bullets.Length; i++)
        {
            if(bullets[i])
            {
                Vector3 selfTobullets = bullets[i].transform.position - transform.position;

                Vector3 checkLength = transform.localScale / 2.0f + bullets[i].transform.localScale / 2.0f;

                if (checkLength.x > Mathf.Abs(selfTobullets.x) && checkLength.y > Mathf.Abs(selfTobullets.y) && checkLength.z > Mathf.Abs(selfTobullets.z))
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}

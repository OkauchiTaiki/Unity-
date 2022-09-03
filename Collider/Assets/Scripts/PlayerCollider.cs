using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player)
        {
            Vector3 selfToPlayer = player.transform.position - transform.position;

            Vector3 checkLength = transform.localScale / 2.0f + player.transform.localScale / 2.0f;

            if (checkLength.x > Mathf.Abs(selfToPlayer.x) && checkLength.y > Mathf.Abs(selfToPlayer.y) && checkLength.z > Mathf.Abs(selfToPlayer.z))
            {
                Destroy(player);
            }
        }
    }
}

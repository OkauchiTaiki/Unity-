using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBullet : MonoBehaviour
{
    public GameObject bullet;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            obj = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(obj, 3.0f);
        }
    }
}

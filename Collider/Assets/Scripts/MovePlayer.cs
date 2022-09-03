using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector4 trans = new Vector4(0f, 0f, 0f, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            trans.z = speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            trans.z = -speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            trans.x = -speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            trans.x = speed * Time.deltaTime;
        }

        Matrix4x4 rotMatrix = Matrix4x4.Rotate(transform.rotation);
        Vector3 transPos = rotMatrix.MultiplyPoint(trans);
        transform.position += transPos;
    }
}

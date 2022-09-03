using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    public float rayLength;
    private Vector3 ray;
    private Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        ray = rayLength * Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < enemys.Length; i++)
        {
            Vector3 playerToEnemy = enemys[i].transform.position - transform.position;
            Vector3 shortestPosition = ray.normalized * Vector3.Dot(playerToEnemy, ray.normalized);
            if(Vector3.Dot(playerToEnemy, ray.normalized) < 0)
            {
                shortestPosition = new Vector3(0.0f, 0.0f, 0.0f);
            }
            if(shortestPosition.magnitude > rayLength)
            {
                shortestPosition = ray.normalized * rayLength;
            }

            Vector3 posToEnemy = playerToEnemy - shortestPosition;

            Vector3 checkLength = enemys[i].transform.localScale / 2.0f;

            if (checkLength.x > Mathf.Abs(posToEnemy.x) && checkLength.y > Mathf.Abs(posToEnemy.y) && checkLength.z > Mathf.Abs(posToEnemy.z))
            {
                enemys[i].GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                enemys[i].GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }
}

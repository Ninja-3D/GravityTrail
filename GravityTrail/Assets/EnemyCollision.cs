using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 thisPlace = transform.localPosition;
        if (collision.gameObject.tag == "Enemy")
        {
            thisPlace.x = -28;
            thisPlace.y = 8;
        }
        transform.localPosition = thisPlace;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

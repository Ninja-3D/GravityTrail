using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 100;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 thisPlace = transform.localPosition;
        if (collision.gameObject.tag == "Enemy")
        {
            thisPlace.x = -31;
            thisPlace.y = -4;
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
        if (Input.GetKeyDown(KeyCode.W))
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private Door key;
    private Teleport2 escape;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            key.KeyCount += 1;
            escape.EscapeNum -= 1;
            Destroy(gameObject);
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        key = FindObjectOfType<Door>();
        escape = FindObjectOfType<Teleport2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

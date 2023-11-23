using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    public float maximumXPosition;
    public float minimumXPosition;
    private Rigidbody2D enemyRigidBody;
    public Teleport teleporter;
    
    // Start is called before the first frame update
    void Start()
    {
        teleporter = FindObjectOfType<Teleport>();
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
        if (collision.gameObject.tag == "ThrowingObject")
        {
            teleporter.enemyCount -= 1;
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition)
        {
            xDirection = 1;
        }
        if (transform.position.x >= maximumXPosition)
        {
            xDirection = -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

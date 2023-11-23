using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Teleport2 : MonoBehaviour
{
    public int EscapeNum;
    public Text collectableCounter;
    // Start is called before the first frame update
    void Start()
    {
        EscapeNum = GameObject.FindGameObjectsWithTag("Key").Length;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && EscapeNum == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    private void Update()
    {
        collectableCounter.text = EscapeNum.ToString();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!playerControllerScript.gameOver)
        {
            Vector3 lookDerection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDerection * speed);
        }
        if (transform.position.y < -10 && !playerControllerScript.gameOver)
        {
            Destroy(gameObject);
        }
    }
}

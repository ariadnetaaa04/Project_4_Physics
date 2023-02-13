using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyspeed;
    private Rigidbody _rigidbody;
    private GameObject player;
    private float yMin = -10f;
    private PlayerController playerController;
    private float originalSpeed = 2.5f;

    // Start is called before the first frame update
    private void Awake()
    {
     _rigidbody = GetComponent<Rigidbody>();   
    }
    void Start()
    {
        enemyspeed = originalSpeed;
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.onFire)
        {
            enemyspeed = 0;
        }
        else
        {
            enemyspeed = originalSpeed;
        }
        Vector3 direction = (player.transform.position - transform.position).normalized; //dos puntos (entre el player y el enemigo. Normalizado para que la distancia entre uno y el otro siempre sea 1.
        _rigidbody.AddForce(direction * enemyspeed); //con la direccion normalidaza siempre ira a velocidad constante porque la distancia entre el enemigo y player siempre es 1. Si no lo tuviera, como mas cerca mas lento se mueve el enemigo y como mas lejos mas sprints dara.
        if (transform.position.y < yMin)
        {
            Destroy(gameObject);
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    private float forwardInput;
    private Rigidbody _rigidbody; //variable vacia por ello en el Start:
    private GameObject focalPoint;
    //Powerup
    public bool hasPowerup;
    public bool drinkPotion;
    public bool onFire;
    private float powerupForce = 15f;
    public GameObject[] powerupIndicators;
    private float originalScale = 1.5f;
    private float powerupScale = 2f;
    


    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); //Le metemos el componente
    }
    void Start()
    {
        
        focalPoint = GameObject.Find("Focal Point");
        

    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        _rigidbody.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountDown());

        }
        if (other.gameObject.CompareTag("Potion"))
        {
            drinkPotion = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountDown());
        }
        if (other.gameObject.CompareTag("Fire"))
        {
            onFire = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountDown());
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer =(other.gameObject.transform.position - transform.position).normalized;
            enemyRigidbody.AddForce(awayFromPlayer * powerupForce, ForceMode.Impulse);
        }
    }

    private IEnumerator PowerupCountDown()
    {
        if (drinkPotion)
        {
            transform.localScale = powerupScale * Vector3.one;
        }
       

        for (int i = 0; i < powerupIndicators.Length; i++)
        {
            powerupIndicators[i].SetActive(true);
            yield return new WaitForSeconds(2);
            powerupIndicators[i].SetActive(false);
        }

        if (drinkPotion)
        {
            transform.localScale = originalScale * Vector3.one;
        }
       
        hasPowerup = false;
        drinkPotion = false;
        onFire = false;
    }
}

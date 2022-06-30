using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    // Here are the private variables
   private  float speed = 20.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    public float forwardInput;
    public float Health = 100f;
    public AudioClip obstacleSound;
    public ParticleSystem collisionParticleSystem;
    public SpriteRenderer sr;
    public bool once = true;



    // Start is called before the first frame update
    void Start()
    {
        


    }
  
    // Update is called once per frame
    void Update()
    {

        // This is where we get player input
       // horizontalInput = Input.GetAxis("Horizontal");


        //if (Application.platform != RuntimePlatform.Android)
         //  forwardInput = Input.GetAxis("Vertical");


       

        // This allows the car to move forward or horizontal
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }

    // this will allow the car to go forward when pressing on the gas pedal
    public void SetForwardVal(float val) 
    {
        forwardInput = val;
    }


    public void SetLeftVal(float val)
    {
        horizontalInput = val;
    }


    public void SetRightVal(float val)
    {
        horizontalInput = val;
    }

    [System.Obsolete]
    void OnCollisionEnter(Collision obj)
    {
        print("Car Collided by " + obj.gameObject.tag);

        if (obj.gameObject.tag == "Obstacles")

        {
            //obj.gameObject.tag = null;


      
            // When the car makes contact with an obstacle, apply damage
            GetComponent<CarHealthManager>().ApplyDamage(10);




            // A patricle effect plays on the obstacle when hit 
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play();

            collisionParticleSystem.transform.position = transform.position;




            //Play a sound effect when hitting obstacles
            AudioSource.PlayClipAtPoint(obstacleSound, transform.position);

        }

    }
}

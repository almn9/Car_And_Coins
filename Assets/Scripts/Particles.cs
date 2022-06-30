using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
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

    }




    [System.Obsolete]
    void OnCollisionEnter(Collision obj)
    {
        print("Car Collided by " + obj.gameObject.tag);

        if (obj.gameObject.tag == "Obstacles")
        {


            // A patricle effect plays on the obstacle when hit 
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play();
        }

}

}

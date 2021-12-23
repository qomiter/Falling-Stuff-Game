using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float thrustMod = 1000.0f;
    [SerializeField] float rotationThrust = 100.0f;
    [SerializeField] AudioClip mainEngine;

    [SerializeField] ParticleSystem mainEngineParticles;
    [SerializeField] ParticleSystem leftThrusterParticles;
    [SerializeField] ParticleSystem rightThrusterParticles;

    Rigidbody rb;
    AudioSource audioSource;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThust();
        ProcessRotate();


    }

    void ProcessThust()
    {
        StartThrusting();
    }

    void StartThrusting()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrustMod * Time.deltaTime);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(mainEngine);
            }
            if (!mainEngineParticles.isPlaying)
            {
                mainEngineParticles.Play();
            }

        }
        else
        {
            audioSource.Stop();
            mainEngineParticles.Stop();
        }
    }

    void ProcessRotate()
    {
        if (Input.GetKey(KeyCode.A))
        {

            if (!rightThrusterParticles.isPlaying)
            {
                rightThrusterParticles.Play();
            }
            else 
            { 
                leftThrusterParticles.Stop(); 
            }
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);
            rb.freezeRotation = false;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (!leftThrusterParticles.isPlaying)
            {
                leftThrusterParticles.Play();
            }
            else 
            { 
                rightThrusterParticles.Stop(); 
            }
            rb.freezeRotation = true;
            transform.Rotate(-Vector3.forward * rotationThrust * Time.deltaTime);
            rb.freezeRotation = false;

        }
    }

}

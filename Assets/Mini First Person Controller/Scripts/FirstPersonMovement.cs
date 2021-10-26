using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;
    public float targetMovingSpeed;
    public int directionStatut = 0;

    Rigidbody rigidbody;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();



    void Awake()
    {
        // Get the rigidbody on this.
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Update IsRunning from input.
        IsRunning = canRun && Input.GetKey(runningKey);

        // Get targetMovingSpeed.
        targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        if (Input.GetKey(KeyCode.Keypad8)) {
            if (this.directionStatut == 0) {
                moveForward();
            }
            if (this.directionStatut == 1) {
                moveLeft();
            }
            if (this.directionStatut == 2) {
                moveBackward();
            }
        }
        if (Input.GetKey(KeyCode.Keypad4)) {
            if (this.directionStatut == 0) {

                moveLeft();
            }
            if (this.directionStatut == 1) {
                moveForward();
            }
            if (this.directionStatut == 2) {
                moveRight();
            }
        }
        if (Input.GetKey(KeyCode.Keypad5)) {
            if (this.directionStatut == 0) {

                moveBackward();
            }
            if (this.directionStatut == 1) {
                moveRight();
            }
            if (this.directionStatut == 2) {
                moveForward();
            }
        }
        if (Input.GetKey(KeyCode.Keypad6)) {
            if (this.directionStatut == 0) {

                moveRight();
            }
            if (this.directionStatut == 1) {
                moveBackward();
            }
            if (this.directionStatut == 2) {
                moveLeft();
            }
        }
    }

    void moveForward()
    {
        transform.position += Vector3.forward * this.targetMovingSpeed *Time.deltaTime;
    }
    void moveBackward()
    {
        transform.position += Vector3.back * this.targetMovingSpeed *Time.deltaTime;
    }
    void moveLeft()
    {
        transform.position += Vector3.left * this.targetMovingSpeed *Time.deltaTime;
    }
    void moveRight()
    {
        transform.position += Vector3.right * this.targetMovingSpeed *Time.deltaTime;
    }

    void OnTriggerExit(Collider col){
        if(col.name == "cmdDirection1") {
            this.directionStatut = 1;
            Destroy(GameObject.Find("cmdDirection1"));
            
        }

        if(col.name == "cmdDirection2") {
            this.directionStatut = 2;
            Destroy(GameObject.Find("cmdDirection2"));
        }
    }

    void OnTriggerStay(Collider other) {
        if(other.name == "tuyau") {
            if ( Input.GetKey(KeyCode.LeftControl))
            {
                // this.transform.position.x += 1;
                // this.transform.position.y += 1;
            }
        }
    }
    void OnTriggerEnter(Collider col){
        if(col.tag == "pique"){
            GameObject.Find("First Person Controller").transform.position = new Vector3(20f, 0f, 60f);
        }
    }
}
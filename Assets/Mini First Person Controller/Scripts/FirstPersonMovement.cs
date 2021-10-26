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
    public int fowardH = 0;
    public int fowardV = 1;
    public int backH = 0;
    public int backV = -1;
    public int leftH = -1;
    public int leftV = 0;
    public int rightH = 0;
    public int rightV = -1;

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
        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Get targetVelocity from input.
        Vector2 targetVelocity =new Vector2( Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        if (Input.GetKey(KeyCode.Keypad8)) {
            // Get targetVelocity from input.
            targetVelocity =new Vector2( (Input.GetAxis("Horizontal")+fowardH) * targetMovingSpeed, (Input.GetAxis("Vertical")+fowardV) * targetMovingSpeed);
        }
        if (Input.GetKey(KeyCode.Keypad6)) {
            // Get targetVelocity from input.
            targetVelocity =new Vector2( (Input.GetAxis("Horizontal")+leftH) * targetMovingSpeed, (Input.GetAxis("Vertical")+leftV) * targetMovingSpeed);
        }
        if (Input.GetKey(KeyCode.Keypad5)) {
            // Get targetVelocity from input.
            targetVelocity =new Vector2( (Input.GetAxis("Horizontal")+rightH) * targetMovingSpeed, (Input.GetAxis("Vertical")+rightV) * targetMovingSpeed);
        }
        if (Input.GetKey(KeyCode.Keypad4)) {
            // Get targetVelocity from input.
            targetVelocity =new Vector2( (Input.GetAxis("Horizontal")+backH) * targetMovingSpeed, (Input.GetAxis("Vertical")+backV) * targetMovingSpeed);
        }

        rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }

    void OnTriggerExit(Collider col){
        if(col.name == "cmdDirection1") {
            int tempForwardH = this.fowardH;
            int tempForwardV = this.fowardV;
            this.fowardH = this.backH;
            this.fowardV = this.backV;
            this.backH = this.rightH;
            this.backV = this.rightV;
            this.rightH = this.leftH;
            this.rightV = this.leftV;
            this.leftH = tempForwardH;
            this.leftV = tempForwardV;
            Destroy(GameObject.Find("cmdDirection1"));
            
        }

        if(col.name == "cmdDirection2") {
            int tempForwardH = this.fowardH;
            int tempForwardV = this.fowardV;
            this.fowardH = this.rightH;
            this.fowardV = this.rightV;
            this.rightH = this.leftH;
            this.rightV = this.leftV;
            this.leftH = this.backH;
            this.leftV = this.backV;
            this.backH = tempForwardH;
            this.backV = tempForwardV;
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
}
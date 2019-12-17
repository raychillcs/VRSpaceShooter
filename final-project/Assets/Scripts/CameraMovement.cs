using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject parent;
    Transform parentTransform;
    public GameObject laserPrefab;
    public float shootSpeed = 300f;

    void Start()
    {
        parentTransform = parent.transform;
    }

    void Update()
    {
        // When we have a horizontal value
        if (Input.GetAxis("Horizontal") != 0)
        {
            // Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
            parent.transform.position += (transform.right) * Input.GetAxis("Horizontal") * 0.3f;
        }

        // When we have a vertical value
        if (Input.GetAxis("Vertical") != 0)
        {
            // Move the attached parent based on the forward vector of this object multiplied by the vertical axis value
            parent.transform.position += (transform.forward) * Input.GetAxis("Vertical") * 0.3f;
        }

        // When you click the trigger
        if (Input.GetButtonDown("Fire1"))
        {
            shootLaser();
        }

        // When you click the X button while looking at (?)
        //if (Input.GetButtonDown("Fire3"))
        //{
        //    // The Unity raycast hit object, which will store the output of our raycast
        //    RaycastHit hit;
        //    // Does the ray intersect any objects excluding the player layer
        //    // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
        //    if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, envLayer))
        //    {
        //        // This takes the current transform of the the camera and set's it's position to have the raycast hit point's x and z while maintaining the same y value
        //        parent.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
        //    }
        //}
    }

    void shootLaser()
    {
        //Instantiate/Create Bullet
        GameObject tempLaser = Instantiate<GameObject>(laserPrefab);

        //Set position  of the bullet in front of the player
        tempLaser.transform.position = transform.position + parentTransform.forward;

        //Get the Rigidbody that is attached to that instantiated bullet
        Rigidbody rbLaser = tempLaser.GetComponent<Rigidbody>();

        //Shoot the Bullet 
        rbLaser.velocity = transform.forward * Time.deltaTime * shootSpeed;

        //GameObject projGO = Instantiate<GameObject>(projectilePrefab);
        //projGO.transform.position = transform.position;
        //Rigidbody rigidB = projGO.GetComponent<Rigidbody>();
        //rigidB.velocity = Vector3.right * projectileSpeed;
    }
}

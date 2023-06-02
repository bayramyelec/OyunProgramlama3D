using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //rb.AddForce(Vector3.forward);


        rb.velocity = new Vector3(0, 0, 8);

        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(100, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(-100, 0, 0, ForceMode.Force);
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Engel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

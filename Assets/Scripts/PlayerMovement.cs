using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed;

    public Vector3 jump;
    public float jumpForce;

    public bool isGrounded;

    private Vector3 spawn;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Josh");
        moveSpeed = 4.0f;
        jumpForce = 2.4f;

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        spawn = transform.position;
    }


    void OnCollisionStay()
   {
       isGrounded = true;
   }

    void OnCollisionExit(){
       isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {

      transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);


      if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
        rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        isGrounded = false;
      }

    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.tag == "Respawn"){
            transform.position = spawn;
        }

        if(collision.transform.tag == "Finish"){
            print("You have completed the game");
        }
    }
}

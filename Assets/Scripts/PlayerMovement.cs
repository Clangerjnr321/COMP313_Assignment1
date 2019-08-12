using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed;

    public Vector3 jump;
    public float jumpForce;

    public bool isGrounded;

    private Vector3 spawn;
    private GameMaster gameMaster;

    public Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = startingPos;
        gameMaster.lastCheckpointPos = startingPos;

        Debug.Log("Hello Josh");
        moveSpeed = 4.0f;
        jumpForce = 2.4f;

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
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

      if(transform.position.y < -1f)
      {
        spawn = gameMaster.lastCheckpointPos;
        transform.position = spawn;
      }

      if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
        rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        isGrounded = false;
      }

    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.tag == "Respawn"){
            spawn = gameMaster.lastCheckpointPos;
            transform.position = spawn;
        }

        if(collision.transform.tag == "Finish"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(collision.transform.tag == "Checkpoint"){
            gameMaster.lastCheckpointPos = transform.position;
        }
    }
}

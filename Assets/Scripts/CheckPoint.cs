using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    private GameMaster gameMaster;
    void Start(){
        gameMaster = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        if(other.transform.tag == "Player"){
            gameMaster.lastCheckpointPos = transform.position;
        }
    }
}

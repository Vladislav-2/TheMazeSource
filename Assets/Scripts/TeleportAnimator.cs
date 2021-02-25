using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAnimator : MonoBehaviour
{

    public Animator animator;

    public void Start(){
     animator = GetComponent<Animator>();
	}

    public void OnTriggerEnter(Collider other){
      if (other.tag == "Player"){
        SetIsNear(true);
	  }
    }

    public void OnTriggerExit(Collider other){
      if (other.tag == "Player"){
        SetIsNear(false);
      }
	}

    public void SetIsNear(bool isNear){
      animator.SetBool("isNear", isNear);
	}
}

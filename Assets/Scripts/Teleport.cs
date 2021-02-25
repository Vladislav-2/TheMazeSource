using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject secondTeleport;
    public TeleportAnimator teleportAnimator;
    public TeleportAnimator secondTeleportAnimator;
    public GameObject prefab;
    private int count;

    public IEnumerator OnTriggerEnter(Collider other){
     if (other.tag == "Player"){
       secondTeleportAnimator.SetIsNear(true);
       yield return new WaitForSeconds(0.5f);
       GameObject gameObject = Instantiate(prefab, secondTeleport.transform.position + new Vector3 (0, 1f, 0), secondTeleport.transform.rotation);
       gameObject.GetComponent<Rigidbody>().AddForce(-secondTeleport.transform.forward * 250f);
       GameObject.Find("MainCamera").GetComponent<CameraController>().player = gameObject;
       count = other.gameObject.GetComponent<PlayerController>().GetCount();
       Destroy(other.gameObject);
       teleportAnimator.SetIsNear(false);
       yield return new WaitForSeconds(1);
       gameObject.AddComponent<PlayerController>();
       gameObject.GetComponent<PlayerController>().SetCount(count);
       gameObject.tag = "Player";
	 }
	}
}

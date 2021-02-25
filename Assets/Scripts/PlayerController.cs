using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 12;
    public int countToWin = 10;
    private Text counter , winner;
    private Rigidbody rb;
    private int count = 0;

    void Start()
    {
        counter = GameObject.Find("CountText").GetComponent<Text>();
        winner = GameObject.Find("WinText").GetComponent<Text>();
        winner.text = "";
        rb = GetComponent<Rigidbody>();
        UpdateCount();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter (Collider other){
        if (other.tag == "Coin"){
          Destroy(other.gameObject); 
          count++;
          UpdateCount();
		}
	}

    void UpdateCount(){
        counter.text = "Coins left: " + (countToWin - count).ToString();
        if (count == countToWin){
          winner.text = "You win!";  
		}
	}

    public void SetCount(int countInPast){
       count = countInPast;
	}

    public int GetCount(){
       return count;
	}
}

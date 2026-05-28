using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
<<<<<<< HEAD
    public AudioSource musicSource;
=======
>>>>>>> eafabc0242d733095bef4c499b9ed4de1c5894ab
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);

<<<<<<< HEAD
            musicSource.Stop();

=======
>>>>>>> eafabc0242d733095bef4c499b9ed4de1c5894ab
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
        if(count>= 12)
        {
<<<<<<< HEAD
            musicSource.Stop();
            winTextObject.gameObject.SetActive(true); 
            winTextObject.GetComponent<TextMeshProUGUI>().text =  "You Win!!";
            
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));   
=======
         winTextObject.gameObject.SetActive(true); 
         winTextObject.GetComponent<TextMeshProUGUI>().text =  "You Win!!";

         Destroy(GameObject.FindGameObjectWithTag("Enemy"));   
>>>>>>> eafabc0242d733095bef4c499b9ed4de1c5894ab
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("pickUP"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro.EditorUtilities;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpForce;
    bool isGrounded = false;
    private AudioSource mySource;
    private UIManager UIManagerScript;
    


    Rigidbody2D RB;


    public spawn spawn;

    // Start is called before the first frame update
    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        UIManagerScript = GameObject.Find("UI Manager").GetComponent<UIManager>();
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) && isGrounded)
        {
            if (isGrounded == true)
             mySource.Play();
                 

            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }
            
           
           


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground")) 
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }


        if (collision.gameObject.CompareTag("engel"))
        {
            // Eðer oyuncu engel nesnesine dokunursa oyunu durdur
            Time.timeScale = 0f;
            UIManagerScript.GetComponent<Canvas>().enabled = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.TryGetComponent(out EngelTriggerKontrol engel))
        {
            spawn.YeniEngelOlustur();
        }

    }
        
}

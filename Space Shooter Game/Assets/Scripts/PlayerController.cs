using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;

    public GameObject lazerBolt;

    public GameManager gameManager;
    
    
    void Start()
    {
      gameManager = GameObject.Find("GameManager").GetComponet<GameManager>();
    }
    
    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");

      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


      if(transform.position.x < -xRange)
      {
        transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
      }  

      if(transform.position.x > xRange)
      {
        transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
      }

      if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
      {
        Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
      }

    }
    private void OnTriggerEnter(Collider other)
      {
        Destroy(other.gameObject);
      }
    
}

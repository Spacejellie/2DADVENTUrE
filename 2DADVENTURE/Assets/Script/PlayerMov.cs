using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public class PlayerMov: MonoBehaviour
{
    public GameObject player;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
       {
         player.transform.position += Vector3.up * speed;
         GameObject.SetBool("walk" , true);
       }
       else 
       {
        GameObject.SetBool("walk" , false);
       }
       if (input.GetKey(KeyCode.W)) &&(Input.GetKey(Keycode.Z))
       {
        GameObject.SetBool("walk" , false);
        GameObject.SetBool("run" , true);
       }
       else 
       {
        GameObject.SetBool("run" , false );
       }
       if (Input.GetKey(KeyCode.S))
       {
         player.transform.position += Vector3.down * speed;
       }
       if (Input.GetKey(KeyCode.A))
       {
         player.transform.position += Vector3.left * speed;
       }
       if (Input.GetKey(KeyCode.D))
       {
         player.transform.position += Vector3.right * speed;
       }
       if (Input.GetKey(KeyCode.Z))
       {
        player.transform.position += Vector3.forward * Time.deltaTime * speed;
       }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Key")
        {
          Destroy(collision.gameObject);
        }
        
    }

}

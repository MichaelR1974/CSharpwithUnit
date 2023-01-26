using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovmentController : MonoBehaviour
{   
    public float speed = 10f;
    Rigidbody2D rigitbody;
    Animator  animator;
    // Start is called before the first frame update
    void Start()
    {
        rigitbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }
    private void OnDisable()
    {
        SceneManager.LoadScene(0);
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);    
        rigitbody.velocity = dir.normalized * speed;

        animator.SetBool("isFlyingLeft",(h > 0));
        animator.SetBool("isFlyingRight", (h < 0));
        animator.SetBool("isFlyingUp", (v > 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

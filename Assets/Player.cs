using UnityEngine;

public class player : MonoBehaviour
{
    public Animator animator;
    public float intputX;
    public float intputY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        intputX = Input.GetAxis("Horizontal");
        intputY = Input.GetAxis("Vertical");

        animator.SetFloat("inputX", intputX);
        animator.SetFloat("inputY", intputY);
        
    }
}

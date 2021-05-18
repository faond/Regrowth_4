using UnityEngine;

public class TransformationParent : MonoBehaviour
{

  public Animator animator;
  public Animator animatorChild;
  public GetTransformed child;
  public bool wilt = true;


  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.transform.CompareTag("Player") && wilt)
      {
        animator.SetTrigger("Bloom");
        animatorChild.SetTrigger("Bloom");
        wilt = false;
      }
      /*else if(collision.transform.CompareTag("Player") && !wilt){
        animator.SetTrigger("Wilt");
        animatorChild.SetTrigger("Wilt");
        wilt = true;
      }*/

  }
}

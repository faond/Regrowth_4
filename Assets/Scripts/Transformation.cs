using UnityEngine;

public class Transformation : MonoBehaviour
{

  public Animator animator;
  public bool wilt = true;

  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.transform.CompareTag("Player"))
      {
        animator.SetTrigger("Wilt");
        wilt = false;
      }
  }
}

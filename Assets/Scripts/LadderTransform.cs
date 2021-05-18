using UnityEngine;

public class LadderTransform : MonoBehaviour
{

  public Animator animator;
  private PlayerMovement playerMovement;
  public bool wilt = true;

  void Awake()
  {
      playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
      if(collision.transform.CompareTag("Player") && wilt && playerMovement.isClimbing)
      {
        animator.SetTrigger("Bloom");
        wilt = false;
      }

  }

  private void OnTriggerStay2D(Collider2D collision)
  {
      if(collision.transform.CompareTag("Player") && wilt && playerMovement.isClimbing)
      {
        animator.SetTrigger("Bloom");
        wilt = false;
      }

  }
}

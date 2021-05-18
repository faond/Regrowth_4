using UnityEngine;

public class Transformation : MonoBehaviour
{

  public Animator animator;
  public bool wilt = true;
  public float timer = -1 ;
  public bool timerIsRunning = false;

  public void Update(){
    if (timerIsRunning)
        {
          if (timer > 0 && !wilt)
          {
              timer -= Time.deltaTime;
          }
          else
          {
            animator.SetTrigger("Wilt");
            wilt = true;
            timer = -1;
            timerIsRunning = false;
          }
        }

  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.transform.CompareTag("Player") && wilt)
      {
        animator.SetTrigger("Bloom");
        wilt = false;
        timer = 5;
        timerIsRunning = true;

      }

  }
}

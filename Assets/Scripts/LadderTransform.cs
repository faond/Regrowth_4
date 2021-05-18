using UnityEngine;

public class LadderTransform : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.transform.CompareTag("Player"))
      {
        Debug.Log("Il y a plus d'un PlayerMovement");
      }

  }
}

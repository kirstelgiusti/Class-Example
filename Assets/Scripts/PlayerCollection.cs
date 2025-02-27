using UnityEngine;

public class PlayerCollection : MonoBehaviour 
{
    
    private void OnTriggerEnter(Collider other)
    {
        // only destroy if its a collectible
        if (other.CompareTag("Collectible"))
        {
              Destroy(other.gameObject);
        }
      
    }

}

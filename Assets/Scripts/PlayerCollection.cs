using UnityEngine;

public class PlayerCollection : MonoBehaviour 
{
    
    // add a scoring system here (HW) 
    
    private void OnTriggerEnter(Collider other)
    {
        // only destroy if its a collectible
        if (other.CompareTag("Collectible"))
        {
              Destroy(other.gameObject);
        }
      
    }

}

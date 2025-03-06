using System.Security.Cryptography;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 respawnPosition;
    public TMP_Text healthText;

    private void Start()
    {
        respawnPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Trap"))
        {
            Damage(1);
        }

        if (other.CompareTag("Checkpoint"))
        {
            // we can set the position based on the checkpoint so that this acts as a guaranteed safe spot 
            respawnPosition = other.transform.position;
            respawnPosition.y = transform.position.y;
        }

    }

    //to remove some health points 
    private void Damage(int value)
    {
        points = points - value;
        healthText.text = $"<b>Health:</b> {points}";
        
        //move the player to the start
        transform.position = respawnPosition; 
        
        //reset points to 5
        // points = 5; 
        
        //if health is 0 or less, destroy player
        if(points < 1)
        {
            Destroy(gameObject);
        }
    }

}



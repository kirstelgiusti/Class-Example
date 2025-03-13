using TMPro;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;
    // add a scoring system here (HW) 
    
    private void OnTriggerEnter(Collider other)
    {
        // only destroy if its a collectible
        if (other.CompareTag("Collectible"))
        {
              Destroy(other.gameObject);
        }
      
    }

    private void AddScore(int points)
    {
        score = score + points;
        scoreText.text = $"<b>Score:</b> {score}";
    }

}

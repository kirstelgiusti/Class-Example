using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Trap"))
        {
            Damage(1);
        }

    }

    //to remove some health points 
    private void Damage(int value)
    {
        points = points - value;
        //if health is 0 or less, destroy player
        if(points < 1)
        {
            Destroy(gameObject);
        }
    }

}

//homework:
//do not destroy
// move the player to the start
// reset points to 5 
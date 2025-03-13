using UnityEngine;

public class EndScreenAnimation : MonoBehaviour
{
    private IEnumerator FadeInOutRoutine()
    {
        yield return new WaitForSeconds(0.25f);
        // fade in  
        
        yield return new WaitForSeconds(1);
        // fade out 
        
        yield return new WaitForSeconds(1);
        // reset 
        
        SceneManager.LoadScene("SampleScene");
    }
}

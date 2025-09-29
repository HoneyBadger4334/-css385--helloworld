using UnityEngine;
//CREDIT: GEMINI
public class ChangeToBlue : MonoBehaviour
{
    
    private Renderer blockRenderer;

    void Start()
    {
        blockRenderer = GetComponent<Renderer>();

        
        if (blockRenderer == null)
        {
            Debug.LogError("Renderer component not found on this GameObject. Cannot change color.");

            return;
        }
        
        blockRenderer.material.color = Color.blue;

        Debug.Log($"Block color successfully changed to {Color.blue}!");
    }

    
}

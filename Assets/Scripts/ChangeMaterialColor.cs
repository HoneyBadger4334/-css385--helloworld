using Unity.Tutorials.Core.Editor;
using UnityEngine;
//CREDIT: https://www.youtube.com/watch?v=VEAU95v5MO8
public class ChangeMaterialColor : MonoBehaviour
{
    [SerializeField] private Material myMaterial;

    
    private void OnTriggerEnter(Collider other)
    {  
	    if(other.CompareTag("Player"))
	    {	
		    myMaterial.color = Color.green;
	    }


    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myMaterial.color = Color.red;
        }


    }
}

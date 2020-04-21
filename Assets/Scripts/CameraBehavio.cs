using UnityEngine;

public class CameraBehavio : MonoBehaviour
{

    public GameObject target;

    private void Update()
    {
        this.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z -10f);
    }
    
}
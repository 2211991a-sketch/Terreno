using UnityEngine;

public class ColisionObjeto : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisionó con: " + collision.gameObject.name);
    }
}

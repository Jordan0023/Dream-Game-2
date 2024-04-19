using UnityEngine;

/// <summary>
/// Spawn an object at a transform's position
/// </summary>
public class SpawnObjectsWithTag : MonoBehaviour
{

    [Tooltip("The transform where the object is spanwed")]
    public Transform spawnPosition = null;

    public void Spawn(string tag)
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject targetObject in taggedObjects)
        Instantiate(targetObject, spawnPosition.position, spawnPosition.rotation);
    }

    private void OnValidate()
    {
        if (!spawnPosition)
            spawnPosition = transform;
    }
}




   
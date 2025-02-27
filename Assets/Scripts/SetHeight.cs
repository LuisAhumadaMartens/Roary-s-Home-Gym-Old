using UnityEngine;

public class SetHeight : MonoBehaviour
{
    private Transform vrCameraTransform;
    private float currentHeight;

    private const string PlayerHeightKey = "PlayerHeight";

    void Start()
    {
        vrCameraTransform = Camera.main.transform;

        if (PlayerPrefs.HasKey(PlayerHeightKey))
        {
            currentHeight = PlayerPrefs.GetFloat(PlayerHeightKey);
        }
        else
        {
            currentHeight = 1.75f; 
        }
    }

    void Update()
    {
        if (vrCameraTransform != null)
        {
            currentHeight = vrCameraTransform.position.y;
        }
    }

    public void SaveHeight()
    {
        if (vrCameraTransform != null)
        {
            PlayerPrefs.SetFloat(PlayerHeightKey, currentHeight);
            PlayerPrefs.Save();
        }
    }
}

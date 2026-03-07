using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30; //limitação da parte de cima do ecrã
    private float lowerBound = -10; //limitação da parte de baixo do ecrã
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // se um objeto passa pelas limitações de cima, ele é destruído
        if (transform.position.z > topBound) {
            Destroy(gameObject); 
        // se um objeto passa pelas limitações de baixo, ele é destruído
        } else if (transform.position.z < lowerBound){
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
    }
}

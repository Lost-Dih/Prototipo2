using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 40.0f; //qual a velocidade do projetil da comida

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //faz com que a comida consiga ser projetada para a frente
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; //input Horizontal_movimentação horizontal do player
    public float speed = 10.0f; //velocidade do player
    public float xRange = 10; //limitações para os lados; espaço onde ele consegue andar
    public GameObject projectilePrefab; //prefab da comida

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mantem o player nas limitações
       if( transform.position.x < -xRange){
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       }
       if(transform.position.x > xRange){
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
       }
       horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
      
       if (Input.GetKeyDown(KeyCode.Space))
       {
        //Lança um projetil a partir do player
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
       }
    }
}

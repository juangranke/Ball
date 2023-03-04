using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public float speed;
    public float jumpForce;
    public Rigidbody2D rig;

    float direction;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Chamado a cada frame.
    void Update() {
        direction = Input.GetAxis("Horizontal"); // Se precisar direita retorna 1, se esquerda retorna -1, se nao presionar retorna 0.

        if (Input.GetKeyDown(KeyCode.Space)) { // Basta colocar outra tecla basta colocar a mesma em maiusculo.
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // Vector2.up Retorna o valor de 1 no y. Vector2.up == new Vector(0, 1)
        }
    }

    // Chamado pela fisica.
    void FixedUpdate() {
        rig.velocity = new Vector2(direction * speed, rig.velocity.y);
    }
}

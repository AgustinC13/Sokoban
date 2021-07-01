using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objetive1Code : MonoBehaviour
{
    public SpriteRenderer color;
    public Collider2D colo;
    public static int puntos = 0;
    public Transform Box;
    public Transform Box_end;

    private void Update()
    {
        if (puntos == 3)
        {
            puntos = 0;
            SceneManager.LoadScene("Victoria");
        }

        if (Box == Box_end)
        {
            color.color = UnityEngine.Color.green;
            Destroy(Box.gameObject);
            colo.enabled = false;
            puntos += 1;
        }
    }

    void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.tag == "Box")
        {

            color.color = UnityEngine.Color.green;
            Destroy(colision.gameObject);
            colo.enabled = false;
            puntos += 1;
        }
    }
}

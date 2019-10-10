using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadLine : MonoBehaviour
{

    public Transform hero;
    public score score;

    Vector3 position;
    private float MaxHeight;
    private float PositionDeadLine;
    private float t_score;
    private float get_score;

    void Update(){
        if (hero.position.y > MaxHeight){
            MaxHeight = hero.position.y;
            PositionDeadLine = MaxHeight - 2;
            position.y = PositionDeadLine;
            transform.position = Vector3.Lerp(transform.position,position, 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            get_score = score.out_score();
            t_score = PlayerPrefs.GetFloat("score");
            if (t_score < get_score) {
                PlayerPrefs.SetFloat("score", score.out_score());
                SceneManager.LoadScene("start_scene");
            }
            else
            {
                SceneManager.LoadScene("start_scene");
            }
            
        }
    }


}

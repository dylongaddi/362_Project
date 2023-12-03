using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public Player player;
    public ParticleSystem explosion; 
    public float respawnTime = 3.0f;
    public int lives = 3; 
    public int score = 0; 

    public void AsteroidDestroyed(Enemy asteroid)
    {
        this.explosion.transform.position = asteroid.transform.position; 
        this.explosion.Play();

        if (asteroid.size < 0.75f) {
            this.score += 100; // small asteroid
        } else if (asteroid.size < 1.2f) {
            this.score += 50; // medium asteroid
        } else {
            this.score += 25; // large asteroid
        }

        
    }

    public void PlayerDied()
    {
        this.explosion.transform.position = this.player.transform.position; 
        this.explosion.Play();

        this.lives--;

        if (this.lives <= 0)
        {
            GameOver();
        }else{

        Invoke(nameof(Respawn), this.respawnTime);
        
        }
    }

    private void Respawn()
    {
        this.player.transform.position = Vector3.zero; 
        //this.player.gameObject.layer = LayerMask.NameToLayer("Ignore Collisions"); 
        
        this.player.gameObject.SetActive(true);
        
        //Invoke(nameof(TurnOnCollisions), 3.0f);
    }

    /*private void TurnOnCollisions(){
        this.player.gameObject.layer = LayerMask.NameToLayer("Player"); 
        
    }*/

    private void GameOver()
    {

    }
}

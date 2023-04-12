using UnityEngine;

public class BulletBase : MonoBehaviour
{

    //Need to look into some object pooling setups for unity since these will be cycled in and out of use often :/

    [SerializeField]
    private float BaseSpeed;
    [SerializeField]
    private Vector2 Direction;

    void OnCollisionEnter2D(Collision2D col){
        //Check tags or scripts on the other object to determine if we need to deal damage, break an obstacle, or remove the bullet
    }

    public void OnPlayerHit(){
        //Handle hurting the correct player and cleaning up
    }

    public void OnObstacleHit(){
        //Same as above, and the name explains it all
    }

    public void OnCleanup(){
        //Handle resetting the state and get ready for entry back into the object pool
    }

}
using UnityEngine;

public class Chest : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        Debug.Log("Grant pesos");
    }
}

using UnityEngine;

[ExecuteInEditMode]
public class HexNeighbours : MonoBehaviour {

    public Hex hex {
        get {
            return Hex.FromWorld(transform.position);
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        foreach (Hex neighbour in hex.Neighbours()) {
            Gizmos.DrawSphere(neighbour.ToWorld(), .25f);
        }
    }

}

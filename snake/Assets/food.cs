using UnityEngine;

public class food : MonoBehaviour
{   
    public BoxCollider2D gridArea;

    private void Start()
    {
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds Bounds = this.gridArea.bounds;
        float x =Random.Range(Bounds.min.x, Bounds.max.x);
        float y =Random.Range(Bounds.min.y, Bounds.max.y);

            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
            if (other.tag == "Player") {
                RandomizePosition();
            }
    }

}

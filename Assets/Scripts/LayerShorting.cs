using UnityEngine;
using System.Collections;

public class LayerShorting : MonoBehaviour {
	public float layerDetail = 0.5f;
  private SpriteRenderer sprite;
	public int posZ = 0;
	private float boundHeight;
	private float spriteHeight;

  void Start() {
  	sprite = GetComponent<SpriteRenderer>();
		spriteHeight = sprite.bounds.size.z;
  }

  void Update() {
  	if (sprite) {
			boundHeight = sprite.bounds.size.z * 0.5f; //* Mathf.Cos(transform.rotation.eulerAngles.x * Mathf.Deg2Rad);
			posZ = -(int)Mathf.Floor(transform.position.z - boundHeight * layerDetail);
  		sprite.sortingOrder = posZ;
    }
 	}
}

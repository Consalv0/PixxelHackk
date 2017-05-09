using UnityEngine;
using System.Collections;

public class LayerShorting : MonoBehaviour {
	public float layerDetail = 2;
  private SpriteRenderer sprite;
	private int posZ = 0;
	private float boundHeight;

  void Start() {
  	sprite = GetComponent<SpriteRenderer>();
  }

  void Update() {
		boundHeight = sprite.bounds.size.z * 0.4142f;
  	if (sprite)
			posZ = -(int)Mathf.Floor(transform.position.z - boundHeight * layerDetail);
  		sprite.sortingOrder = posZ;
    }
 	}

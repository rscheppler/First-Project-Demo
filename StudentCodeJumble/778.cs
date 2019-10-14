﻿

		void Awake ()
		{
			_colliders = GetComponents<Collider2D> ();
			_rigidbody = GetComponent<Rigidbody2D> ();
			_renderer = GetComponent<SpriteRenderer> ();
		}

		void Update ()
		{
			if (transform.position.y < -4) {
				DestroyThis ();
			}
		}

		void OnTriggerEnter2D (Collider2D other)
		{
			if (other.gameObject.CompareTag ("Darkness")) {
				DestroyThis ();
			}
		}

		private void DestroyThis ()
		{
			if (_beingDestroyed)
				return;

			_beingDestroyed = true;
			
			if (!falling) {
				DisableColliderCollisions ();
				
				_rigidbody.isKinematic = false;
			}
			
			
			_renderer.enabled = false;
			
			if (explosionParticleContainer) {
				explosionParticleContainer.SetActive (true);
			}
			
			StartCoroutine (Destroy ());
		}

		void OnTriggerExit2D (Collider2D other)
		{
			if (playerTouched && other.gameObject.CompareTag ("Player")) {
				DisableColliderCollisions ();
				_rigidbody.isKinematic = false;

				falling = true;
			}
		}

		private void DisableColliderCollisions ()
		{
			foreach (var c in _colliders) {
				c.isTrigger = true;
			}
		}
			
		private IEnumerator Destroy ()
		{
			yield return new WaitForSeconds (2f);
			Destroy (gameObject);
		}
	}

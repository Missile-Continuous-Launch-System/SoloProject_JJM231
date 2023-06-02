using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour {

  // The image to fade out.
  public Image image;

  // The duration of the fade out, in seconds.
  public float duration = 2.0f;

  // The start time of the fade out.
  private float startTime;

  // The current alpha of the image.
  private float alpha = 1.0f;

  void Start() {
    // Start the fade out.
    startTime = Time.time;
  }

  void Update() {
    // Calculate the current alpha.
    alpha = Mathf.Lerp(1.0f, 0.0f, (Time.time - startTime) / duration);

    // Set the alpha of the image.
    image.color = new Color(1.0f, 1.0f, 1.0f, alpha);
  }
}
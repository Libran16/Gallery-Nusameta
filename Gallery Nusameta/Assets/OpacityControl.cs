using UnityEngine;

public class OpacityControl : MonoBehaviour
{
    // Nilai kejernihan awal (1.0 = sepenuhnya terlihat, 0.0 = sepenuhnya transparan)
    public float initialOpacity = 1.0f;

    // Renderer komponen objek
    private Renderer objectRenderer;

    void Start()
    {
        // Dapatkan komponen Renderer dari objek
        objectRenderer = GetComponent<Renderer>();

        // Set kejernihan awal
        SetOpacity(initialOpacity);
    }

    // Fungsi untuk mengatur kejernihan objek
    void SetOpacity(float opacity)
    {
        // Dapatkan warna saat ini dari material objek
        Color objectColor = objectRenderer.material.color;

        // Tetapkan nilai alpha ke opacity yang diberikan
        objectColor.a = opacity;

        // Tetapkan warna yang telah diubah kembali ke material objek
        objectRenderer.material.color = objectColor;
    }

    void Update()
    {
        // Contoh: Menurunkan opacity seiring waktu
        float newOpacity = Mathf.Lerp(1.0f, 0.0f, Mathf.PingPong(Time.time, 1.0f));
        SetOpacity(newOpacity);
    }
}

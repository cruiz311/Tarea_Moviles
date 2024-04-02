using UnityEngine;

[CreateAssetMenu(fileName = "NuevoPersonaje", menuName = "DatosPersonaje")]
public class DatosPersonaje : ScriptableObject
{
    public Sprite sprite;
    public int vida;
    public int VelocidadVertical;
    public int VelocidadHorizontal;
}

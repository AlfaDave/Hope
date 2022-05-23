using UnityEngine;

public class GameStyle : MonoBehaviour
{
    public static GameStyle Style;
    #region Default
    [Header("Default Theme Items")]
    public Sprite image_Background_Default;
    public Sprite image_TileDetail_1_Default;
    public Sprite image_TileDetail_2_Default;
    public Sprite image_TileDetail_3_Default;
    public Sprite image_Boss_1_Default;
    public Sprite image_Boss_2_Default;
    public Sprite image_Boss_3_Default;
    #endregion
    [Space(20)]
    #region Dino
    [Header("Default Theme Items")]
    public Sprite image_Background_Dino;
    public Sprite image_TileDetail_1_Dino;
    public Sprite image_TileDetail_2_Dino;
    public Sprite image_TileDetail_3_Dino;
    public Sprite image_Boss_1_Dino;
    public Sprite image_Boss_2_Dino;
    public Sprite image_Boss_3_Dino;

    #endregion


    private void Awake()
    {
        if (Style == null)
        {
            Style = this;
        }
    }
}

using System.Drawing;

namespace DAL.Model.Yugioh
{
    public class YugiohImageModel
    {
        public const string CardImage = "card_image/";
        public const string CardName = "card_name=";
        public const string QueryParameter = "?";

        public Image Image { get; set; }
    }
}

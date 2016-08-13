using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DAL.Interface.Yugioh;
using DAL.Model.Yugioh;

namespace DAL.Repository.Yugioh
{
    public class YugiohCardsRepository : BaseRepository, IYugiohCardsRepository
    {
        public YugiohCardsRepository()
        {
            Client.BaseAddress = new Uri("http://yugiohprices.com/api/");
        }

        public async Task<YugiohCardModel> GetCardData(string name)
        {
            HttpResponseMessage response = await Client.GetAsync(YugiohCardModel.CardData + name + YugiohCardModel.QueryParameter + YugiohCardModel.CardName + name);
            return await GetJsonResponse<YugiohCardModel>(response);
        }

        public async Task<YugiohImageModel> GetCardPicture(string name)
        {
            HttpResponseMessage response = await Client.GetAsync(YugiohImageModel.CardImage + name + YugiohImageModel.QueryParameter +  YugiohImageModel.CardName + name);
            using (HttpClient imageClient = new HttpClient())
            {
                imageClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("image/jpg"));
                byte[] data = await imageClient.GetByteArrayAsync(response.RequestMessage.RequestUri);
                using (MemoryStream ms = new MemoryStream(data))
                {
                    Image returnImage = Image.FromStream(ms);
                    return new YugiohImageModel
                    {
                        Image = returnImage
                    };
                }
            }          
        }
    }
}

using Api.Entities.Jsons.JsonInput;
using Api.Models;

namespace Api.Services
{
    public class Mapper
    {
        public static UsersModel JsonUserToModel(JsonUser json)
        {
            UsersModel user = new UsersModel()
            {
                Name = json.Name,
                Password = json.Password,
                Email = json.Email,
                PhoneNumber = json.PhoneNumber,
                UserType = json.UserType
            }; 
            return user;
        }

        public static ProductsModel JsonProductToModel(JsonProduct json)
        {
            ProductsModel product = new ProductsModel()
            {
                Name = json.Name,
                Value = json.Value,
                Amount = json.Amount,
                Description = json.Description,
            }; 
            return product;
        }
    }
}
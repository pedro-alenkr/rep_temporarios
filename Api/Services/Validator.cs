using Api.Models;

namespace Api.Services.Validations
{
    public static class Validator
    {
        public static void ExecuteValidator(ApiDAO apiDAO, UsersModel user){
            apiDAO.ValidateUser(user);
        }

        public static void ExecuteValidator(ApiDAO apiDAO, ProductsModel product){
            apiDAO.ValidateProduct(product);
        }
    }
}
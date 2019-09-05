using COM.Checkout.Payment.Api.Contract.DTO.MessageRequest;
using Framework.Database;
using System.Net.Http;

namespace COM.Checkout.Payment.Api.Service
{
    /// <summary>
    /// Payment module
    /// </summary>
    public interface IPaymentServices
    {
        /// <summary>
        /// Ajout d'une nouvelle liste DV
        /// </summary>
        /// <param name="context"></param>
        /// <param name="listeDVitemRequestDTO"></param>
        /// <returns></returns>
        HttpResponseMessage InsertListeDV(IDbContext context,CardDetailsRequestDTO listeDVitemRequestDTO);

        /// <summary>
        /// Mise à jour d'une liste DV existante
        /// </summary>
        /// <param name="context"></param>
        /// <param name="listeDVitemRequestDTO"></param>
        /// <returns></returns>
        HttpResponseMessage UpdateListeDV(IDbContext context, CardDetailsRequestDTO listeDVitemRequestDTO);
    }
}

using System.Data;
using System.ServiceModel;

namespace DietHolderServiceLibrary
{
    [ServiceContract]
    public interface IDatabaseManager
    {
        [OperationContract]
        DataTable ShowAllPositionsFromTableProducts();
        [OperationContract]
        DataTable SearchProduct(DataToInteractWithDatabase interactWithDatabase);
        [OperationContract]
        void InsertProduct(Product product);
        [OperationContract]
        void UpdateProduct(Product product);
        [OperationContract]
        void DeleteProduct(DataToInteractWithDatabase dataToInteract);
    }
}

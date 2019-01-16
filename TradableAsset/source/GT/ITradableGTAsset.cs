using Expload.Pravda;

namespace Expload.Standards
{
    public interface ITradableGTAsset : ITradableAsset
    {
        /// <summary>
        /// Get GT asset data
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// Asset object
        /// </returns>
        Asset GetGTAssetData(long id);

        /// <summary>
        /// Get GT asset owner
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// Owner address
        /// </returns>
        Bytes GetGTAssetOwner(long id);

        /// <summary>
        /// Get GT asset class id
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// Class id
        /// </returns>
        Bytes GetGTAssetClassId(long id);

        /// <summary>
        /// Get amount of GT assets belonging to a user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <returns>
        /// Asset amount
        /// </returns>
        long GetUsersGTAssetCount(Bytes address);

        /// <summary>
        /// Get asset id of a particular GT asset belonging to a user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <param name="number"> Asset serial number </param>
        /// <returns>
        /// Asset id
        /// </returns>
        long GetUsersGTAssetId(Bytes address, long number);

        /// <summary>
        /// Get list of GT assets
        /// belonging to a particular user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <returns>
        /// List of asset objects
        /// </returns>
        Asset[] GetUsersAllGTAssetsData(Bytes address);

        /// <summary>
        /// Emit a GT asset
        /// </summary>
        /// <param name="owner"> Desired asset owner </param>
        /// <param name="classId"> Asset class id </param>
        /// <param name="instanceId"> Asset instance id </param>
        /// <returns>
        /// Emitted asset id
        /// </returns>
        long EmitGTAsset(Bytes owner, Bytes classId, Bytes instanceId);

        /// <summary>
        /// Transfer GT asset to a new owner
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <param name="to"> New owner address </param>
        void TransferGTAsset(long id, Bytes to);
    }
}
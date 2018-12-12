using Expload.Pravda;

namespace Expload.Standarts
{
    public interface ITradableAsset
    {
        /// <summary>
        /// Get JSONified GT asset data
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// JSON object
        /// </returns>
        string GetGTAssetData(long id);

        /// <summary>
        /// Get GT asset owner
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// Owner address
        /// </returns>
        Bytes GetGTAssetOwner(long id);

        /// <summary>
        /// Get GT asset external id
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// External id
        /// </returns>
        Bytes GetGTAssetExternalId(long id);

        /// <summary>
        /// Get JSONified XC asset data
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// JSON object
        /// </returns>
        string GetXCAssetData(long id);

        /// <summary>
        /// Get XC asset owner
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// Owner address
        /// </returns>
        Bytes GetXCAssetOwner(long id);

        /// <summary>
        /// Get XC asset external id
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <returns>
        /// External id
        /// </returns>
        Bytes GetXCAssetExternalId(long id);

        /// <summary>
        /// Get amount of GT assets belonging to a user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <returns>
        /// Asset amount
        /// </returns>
        long GetGTUsersAssetCount(Bytes address);

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
        /// Get JSONified lists of GT assets
        /// belonging to a particular user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <returns>
        /// JSON object
        /// </returns>
        string GetUsersAllGTAssetsData(Bytes address);

        /// <summary>
        /// Get amount of XC assets belonging to a user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <returns>
        /// Asset amount
        /// </returns>
        long GetXCUsersAssetCount(Bytes address);

        /// <summary>
        /// Get asset id of a particular XC asset belonging to a user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <param name="number"> Asset serial number </param>
        /// <returns>
        /// Asset id
        /// </returns>
        long GetUsersXCAssetId(Bytes address, long number);

        /// <summary>
        /// Get JSONified lists of XC assets
        /// belonging to a particular user
        /// </summary>
        /// <param name="address"> User address </param>
        /// <returns>
        /// JSON object
        /// </returns>
        string GetUsersAllXCAssetsData(Bytes address);

        /// <summary>
        /// Set up Expload Auction address
        /// </summary>
        /// <param name="address"> Auction address </param>
        void SetAuction(Bytes address);

        /// <summary>
        /// Emit a GT asset
        /// </summary>
        /// <param name="owner"> Desired asset owner </param>
        /// <param name="externalId"> Asset external id </param>
        /// <param name="metaId"> Asset meta id </param>
        /// <returns>
        /// Emitted asset id
        /// </returns>
        long EmitGTAsset(Bytes owner, Bytes externalId, Bytes metaId);

        /// <summary>
        /// Transfer GT asset to a new owner
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <param name="to"> New owner address </param>
        void TransferGTAsset(long id, Bytes to);

        /// <summary>
        /// Emit a XC asset
        /// </summary>
        /// <param name="owner"> Desired asset owner </param>
        /// <param name="externalId"> Asset external id </param>
        /// <param name="metaId"> Asset meta id </param>
        /// <returns>
        /// Emitted asset id
        /// </returns>
        long EmitXCAsset(Bytes owner, Bytes externalId, Bytes metaId);

        /// <summary>
        /// Transfer XC asset to a new owner
        /// </summary>
        /// <param name="id"> Asset id </param>
        /// <param name="to"> New owner address </param>
        void TransferXCAsset(long id, Bytes to);
    }
}
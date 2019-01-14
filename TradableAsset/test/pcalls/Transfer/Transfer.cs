namespace Expload.Standards {

    using Pravda;
    using System;

    [Program]
    public class Transfer {
        public static void Main() {}

        public Asset test_Transfer(){
            // Init addresses and get program by address
            Bytes programOwner = new Bytes("fb75559bb4bb172ca0795e50b390109a50ce794466a14c24c73acdb40604065b");
            Bytes assetOwner = new Bytes("e04919086e3fee6f1d8f6247a2c0b38f874ab40a50ad2c62775fb09baa05e342");
            Bytes newAssetOwner = new Bytes("0000000000000000000000000000000000000000000000000000000000000000");

            // Set auction address to this contract address
            ProgramHelper.Program<TradableGTAsset>(programOwner).SetAuction(Info.ProgramAddress());

            // Emit the asset
            Bytes externalId = new Bytes("0000000000000000000000000000000000000000000000000000000000000001");
            Bytes metaId = new Bytes("0000000000000000000000000000000000000000000000000000000000000002");
            long assetId = ProgramHelper.Program<TradableGTAsset>(programOwner).EmitGTAsset(
                assetOwner, externalId, metaId
            );

            // Transfer asset to another address
            ProgramHelper.Program<TradableGTAsset>(programOwner).TransferGTAsset(assetId, newAssetOwner);

            // Return asset object
            return ProgramHelper.Program<TradableGTAsset>(programOwner).GetGTAssetData(assetId);
        }
    }
}
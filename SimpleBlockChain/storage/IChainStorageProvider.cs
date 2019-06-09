using System.Collections.Generic;
using System;

namespace SimpleBlockChain{
    public interface IChainStorageProvider
    {
        void initiate();
        Boolean Add(Block block);
        long Count();
        Block Retrieve(long blockNumber);
        Block PopBlock();
        List<Block> RetrieveAll();
        void Restore(List<Block> chain);
    }
}

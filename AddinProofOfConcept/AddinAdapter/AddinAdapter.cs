﻿using AddinView;
using ContractV1;
using System.AddIn.Pipeline;

namespace AddinAdapter
{
    [AddInAdapter]
    public class AddinAdapter : ContractBase, IContractV1
    {
        private IV1 _contract;

        public AddinAdapter(IV1 contract)
        {
            _contract = contract;
        }

        public string GetName()
        {
            return _contract.GetName();
        }

        public void WriteToConsole()
        {
            _contract.WriteToConsole();
        }
    }
}
﻿namespace Weka.NET.Associations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Weka.NET.Core;
    using Weka.NET.Utils;

    public interface IApriori
    {
        IList<AssociationRule> BuildAssociationRules(IDataSet dataSet);
    }

    public class Apriori : IApriori
    {
        readonly IItemSetBuilder itemSetBuilder;

        readonly RuleBuilder ruleBuilder;

        public Apriori(IItemSetBuilder iItemSetBuilder, RuleBuilder ruleBuilder)
        {
            this.itemSetBuilder = iItemSetBuilder;
            this.ruleBuilder = ruleBuilder;
        }

        public IList<AssociationRule> BuildAssociationRules(IDataSet dataSet)
        {
            var itemSets = itemSetBuilder.BuildItemSets(dataSet);

            var rules = ruleBuilder.BuildRules(itemSets);

            return rules;
        }
    }
}
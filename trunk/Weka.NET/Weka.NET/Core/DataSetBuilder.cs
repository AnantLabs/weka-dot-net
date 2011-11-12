﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weka.NET.Core
{
    public class DataSetBuilder
    {
        readonly DataSet originalSet;

        IList<Instance> instances;

        public int Count { get { return instances.Count; } }

        public DataSetBuilder(DataSet originalSet)
        {
            this.originalSet = originalSet;

            instances = new List<Instance>(this.originalSet.Instances);
        }

        internal void DeleteWithMissingClass(int classIndex)
        {
            var enumerator = instances.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (false == enumerator.Current[classIndex].HasValue)
                {
                    
                }
            }
        }

        internal DataSet Build()
        {
            return new DataSet(instances: instances);
        }
    }
}

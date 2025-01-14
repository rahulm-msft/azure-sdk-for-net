// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a selector in the Experiment resource. </summary>
    public partial class Selector
    {
        /// <summary> Initializes a new instance of Selector. </summary>
        /// <param name="selectorType"> Enum of the selector type. </param>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="targets"> List of Target references. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="targets"/> is null. </exception>
        public Selector(SelectorType selectorType, string id, IEnumerable<TargetReference> targets)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(targets, nameof(targets));

            SelectorType = selectorType;
            Id = id;
            Targets = targets.ToList();
        }

        /// <summary> Initializes a new instance of Selector. </summary>
        /// <param name="selectorType"> Enum of the selector type. </param>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="targets"> List of Target references. </param>
        /// <param name="filter">
        /// Model that represents available filter types that can be applied to a targets list.
        /// Please note <see cref="Filter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SimpleFilter"/>.
        /// </param>
        internal Selector(SelectorType selectorType, string id, IList<TargetReference> targets, Filter filter)
        {
            SelectorType = selectorType;
            Id = id;
            Targets = targets;
            Filter = filter;
        }

        /// <summary> Enum of the selector type. </summary>
        public SelectorType SelectorType { get; set; }
        /// <summary> String of the selector ID. </summary>
        public string Id { get; set; }
        /// <summary> List of Target references. </summary>
        public IList<TargetReference> Targets { get; }
        /// <summary>
        /// Model that represents available filter types that can be applied to a targets list.
        /// Please note <see cref="Filter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SimpleFilter"/>.
        /// </summary>
        public Filter Filter { get; set; }
    }
}
